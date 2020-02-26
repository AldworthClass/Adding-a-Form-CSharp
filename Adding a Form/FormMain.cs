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
            //Add some names to our list
            names.Add("Worf");
            names.Add("Picard");
            names.Add("Data");
            names.Add("Troi");
            lstNames.DataSource = names;    //update the ListBos
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            names.Sort();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                FormChangeName frmChangeName = new FormChangeName(lstNames.SelectedIndex);
                frmChangeName.ShowDialog();
                names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = names;
            }
            else
                MessageBox.Show("No name selected!");            
        }

        private void btnRemoveNames_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                names.RemoveAt(lstNames.SelectedIndex);
                names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = names;
            }
                
            
        }
    }
}
