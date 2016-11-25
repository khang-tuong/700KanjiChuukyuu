using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService;
using CoreService.Model;

namespace _700KanjiChuukyuu
{
    public partial class AddSectionForm : Form
    {
        public AddSectionForm()
        {
            InitializeComponent();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Section s = new Section();
                s.Name = this.txtName.Text;
                string r = DataManager.AddSection(s);
                if (r != null)
                {
                    MessageBox.Show(r);
                } else 
                this.Dispose();
            }
        }
    }
}
