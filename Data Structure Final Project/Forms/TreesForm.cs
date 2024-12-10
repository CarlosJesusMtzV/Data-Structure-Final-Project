using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Final_Project
{
    public partial class TreesForm : ZBase
    {
        private BinaryTree.Node root;
        public TreesForm()
        {
            InitializeComponent();
            root = new BinaryTree.Node();
        }


        private void DrawTree()
        {
            // Este método será usado para dibujar el árbol en un control como un PictureBox
            using (Graphics g = panelTree.CreateGraphics())
            {
                g.Clear(Color.White); // Limpia el panel antes de dibujar

                if (root.value != null)
                {
                    DrawNode(g, root, panelTree.Width / 2, 20, 100); // Comienza a dibujar desde el centro del Panel
                }
            }
        }

        private void DrawNode(Graphics g, BinaryTree.Node node, int x, int y, int xOffset)
        {
            if (node == null) return;

            // Limitar la posición dentro del Panel
            int panelWidth = panelTree.Width;
            int panelHeight = panelTree.Height;

            // Asegurar que las coordenadas x, y no se salgan del área del Panel
            x = Math.Max(30, Math.Min(panelWidth - 30, x));   // Limita x entre 30 y panelWidth - 30
            y = Math.Max(30, Math.Min(panelHeight - 30, y));  // Limita y entre 30 y panelHeight - 30

            // Dibuja el nodo
            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30);
            g.DrawString(node.value.ToString(), this.Font, Brushes.Black, x - 10, y - 10);

            // Dibuja las aristas
            if (node.left != null)
            {
                int leftX = x - xOffset;
                int leftY = y + 60;
                g.DrawLine(Pens.Black, x, y, leftX, leftY);
                DrawNode(g, node.left, leftX, leftY, xOffset / 2);
            }

            if (node.right != null)
            {
                int rightX = x + xOffset;
                int rightY = y + 60;
                g.DrawLine(Pens.Black, x, y, rightX, rightY);
                DrawNode(g, node.right, rightX, rightY, xOffset / 2);
            }
        }

        private void btnInsertNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeValue.Text, out int value))
            {
                root.Insert(value);
                DrawTree();
                txtNodeValue.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeValue.Text, out int value))
            {
                root = root.Delete(root, value); // Elimina el nodo
                DrawTree();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeValue.Text, out int value))
            {
                BinaryTree.Node foundNode = root.Search(value);
                MessageBox.Show(root.GetNodeInfo(foundNode, "Found"));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            root = new BinaryTree.Node(); // Establece la raíz a null, eliminando todo el árbol
            DrawTree();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            string result = PreOrderTraversal(root);
            txtOutput.Text = result;
        }
        private string PreOrderTraversal(BinaryTree.Node node)
        {
            if (node == null) return "";
            return node.value.ToString() + ", " + PreOrderTraversal(node.left) + PreOrderTraversal(node.right);
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            string result = InOrderTraversal(root);
            txtOutput.Text = result;
        }

        private string InOrderTraversal(BinaryTree.Node node)
        {
            if (node == null) return "";
            return InOrderTraversal(node.left) + node.value.ToString() + ", " + InOrderTraversal(node.right);
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            string result = PostOrderTraversal(root);
            txtOutput.Text = result;
        }

        private string PostOrderTraversal(BinaryTree.Node node)
        {
            if (node == null) return "";
            return PostOrderTraversal(node.left) + PostOrderTraversal(node.right) + node.value.ToString() + ", ";
        }
    }
}
