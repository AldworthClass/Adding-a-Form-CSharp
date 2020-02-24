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
    public partial class FormMain : Form
    {
        public static List<string> names = new List<string>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddName frmAddName = new FormAddName();  
            frmAddName.ShowDialog();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            names.Add("Bear");
            names.Add("Marigold");
            names.Add("Humpty");
            names.Add("Dumpty");
            lstNames.DataSource = names;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
