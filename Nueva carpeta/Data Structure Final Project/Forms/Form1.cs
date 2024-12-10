using System.Security.Cryptography.Xml;

namespace Data_Structure_Final_Project
{
    public partial class Form1 :ZBase
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (lBoxOptions.SelectedIndex)
            {
                case 0:
                    ListsForm listsForm = new ListsForm();
                    listsForm.Show();
                    this.Hide();
                    break;
                case 1:
                    StacksForm stacksForm = new StacksForm();
                    stacksForm.Show();
                    this.Hide();
                    break;
                case 2:
                    QueuesForm queuesForm = new QueuesForm();
                    queuesForm.Show();
                    this.Hide();
                    break;
                case 3:
                    TreesForm treesForm = new TreesForm();
                    treesForm.Show();
                    this.Hide();
                    break;
                case 4:
                    GraphsForm graphsForm = new GraphsForm();
                    graphsForm.Show();
                    this.Hide();
                    break;
                case 5:
                    AlgorithmsForm algorithmsForm = new AlgorithmsForm();
                    algorithmsForm.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
