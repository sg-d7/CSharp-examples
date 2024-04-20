using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFillUp_Click(object sender, EventArgs e)
        {
            int num = 10;
            for (int i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add("Text Item " + (i + 1).ToString());
                lvRunTime.Items.Add(item);
            }
        }

        private void btnDeleteSel_Click(object sender, EventArgs e)
        {
            if (lvRunTime.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }

            lvRunTime.Items.Remove(lvRunTime.SelectedItems[0]);
        }
    }
}
