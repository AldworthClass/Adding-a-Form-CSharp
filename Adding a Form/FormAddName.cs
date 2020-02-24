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
            FormMain.names.Add(txtAddName.Text.Trim());
            lstNames.DataSource = null;
            lstNames.DataSource = FormMain.names;
        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = FormMain.names;   //Fills ListBox with names
        }
    }
}
