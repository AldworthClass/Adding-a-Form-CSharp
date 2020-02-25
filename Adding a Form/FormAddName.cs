using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_a_Form
{
    public partial class FormAddName : Form
    {
        public FormAddName()
        {
            InitializeComponent();
        }
        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (FormMain.names.Contains(txtAddName.Text.Trim()))
                MessageBox.Show("Name already exists!");
            else if (txtAddName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please type a name!");
            }
            else
            { 
                FormMain.names.Add(txtAddName.Text.Trim());
                FormMain.names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = FormMain.names;
            }
        }
        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = FormMain.names;   //Fills ListBox with names
            lstNames.SelectedIndex = -1;            //No items are selected initially
        }
    }
}
