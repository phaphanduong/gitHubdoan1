using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tudien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "" && txtpass.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập username hoặc password!");
                    return;
                }
                if (txtuser.Text == "admin" && txtpass.Text == "admin")
                {
                    this.Hide();
                    new Quanly().ShowDialog();
                }
                else
                {
                    MessageBox.Show("sai username hoặc password");
                }

            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
