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
    public partial class FormChangeName : Form
    {
        int index;
        public FormChangeName(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                FormMain.names[index] = txtName.Text.Trim();
                this.Dispose();
            }
            else
                MessageBox.Show("Please type a name.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormChangeName_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Old name: {FormMain.names[index]}";
        }
    }
}
