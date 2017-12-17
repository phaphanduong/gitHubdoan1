using Microsoft.ApplicationBlocks.Data;
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
    public partial class Quanly : Form
    {
        fmain fm = new fmain();
        // Chuỗi kết nối 
        string strConnectionString = "Data Source=DESKTOP-V8T7PFO;Initial Catalog=testDA;Integrated Security=True";
        public Quanly()
        {
            InitializeComponent();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                //khai báo các biến truyền vào
                string Tu = tbthemtu.Text.Trim();
                string Nghia = tbnghia.Text.Trim();
                //truyền dữ liệu lên sql
                SqlHelper.ExecuteNonQuery(strConnectionString, "Tu_Them", Tu, Nghia);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, lỗi rồi!");
            }
        }

        private void loaddata()
        {
            Grvdata.DataSource = SqlHelper.ExecuteDataset(strConnectionString, "Tu_Select").Tables[0];
        }

        private void setValue(int index)
        {
            try
            {
                DataGridViewRow row = Grvdata.Rows[index];
                tbthemtu.Text = row.Cells[0].Value.ToString();
                tbnghia.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btlamlai_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Grvdata_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            tbthemtu.Clear();
            tbnghia.Clear();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Tu = tbthemtu.Text.Trim();
                SqlHelper.ExecuteNonQuery(strConnectionString, "Tu_Xoa", Tu);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được, lỗi rồi!");
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                string Tu = tbthemtu.Text.Trim();
                string Nghia = tbnghia.Text.Trim();
                SqlHelper.ExecuteNonQuery(strConnectionString, "Tu_Sua", Tu, Nghia);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được, lỗi rồi!");
            }
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            loaddata();
        }


    }
}
