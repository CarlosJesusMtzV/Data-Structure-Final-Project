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
    public partial class ZBase : Form
    {
        public ZBase()
        {
            this.FormClosed += AnyFormClosed;
        }

        protected void AnyFormClosed(object sender, FormClosedEventArgs e)
        {

            if (sender is Form form && form is not Form1)
            {
                Form1 mainForm = Application.OpenForms["Form1"] as Form1;
                if (mainForm != null)
                {
                    mainForm.Show();
                }
            }
        }

    }
    }
