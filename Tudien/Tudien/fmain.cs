
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using SpeechLib;

namespace Tudien
{
    public partial class fmain : Form
    {
        // Chuỗi kết nối 
            string strConnectionString = "Data Source=DESKTOP-V8T7PFO;Initial Catalog=DA1;Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu Từ hai bảng Chi tiết hóa đơn để đưa lên combobox
        SqlDataAdapter daTD = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtTD = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataView dtvTD = null;
      public void LoadTD() {
            try
            {
                //khởi dộng connection kết nối đến DB
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                //lấy dữ liệu từ bảng danh sách từ 
                //tạo đối tượng SqlAdapter là cầu nối giữa dataset và datasource để thực hiện công việc như đọc hay cập nhật dữ liệu
                daTD = new SqlDataAdapter("SELECT * FROM Tu ", conn);
                //// khởi tạo đối tượng datatable
                dtTD = new DataTable();
                dtTD.Clear();
                //// fill dữ liệu vào datatable
                daTD.Fill(dtTD);
  

                // Đưa dữ liệu lên dgvsach
                //nếu dữ liệu được hiển thị ra datagridview .Ta cần 1 DataView kết nối đến DataTable .Đối tượng DataView dùng cho việc sắp xếp,lọc, tìm kiếm
                dtvTD = new DataView(dtTD);
                // gán datasource cho datagridview
                dgvTD.DataSource = dtvTD;
                dgvTD.Columns[1].Visible = false;

            }
            catch (SystemException er)
            {

                MessageBox.Show(er.Message);
            }
        }
        public fmain()
        {
            InitializeComponent();


        }
            public struct Entry
            {
                public int hashCode;    // Lower 31 bits of hash code, -1 if unused
                public int next;        // Index of next entry, -1 if last
                public string key;           // Key of entry
                public string value;         // Value of entry
            }
            public int[] buckets;   
            public Entry[] entries;
            public int count;           
            public int version;
            public int freeList;    
            public int freeCount;
            public void Initialize(int size)
            {
            //khoi tao mang bucket
            buckets = new int[size];
                for (int i = 0; i < buckets.Length; i++) buckets[i] = -1;
                entries = new Entry[size];
                freeList = -1;
            }

            public void Insert(string keys, string values, bool add)
            {
                //khởi tạo bucket
                if (buckets == null) Initialize(0);
                //lấy giá trị băm của từ
                int hashCode = GetHashCode(keys)& 0x7FFFFFFF;
                //hàm băm từ 
                int targetBucket = hashCode % buckets.Length;
                
                //for (int i = buckets[targetBucket]; i >= 0; i = entries[i].next)
                //{
                //    if (entries[i].hashCode == hashCode && Comparer.Equals(entries[i].key, keys))
                //    {
                //        if (add)
                //        {
                //            //ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
                //        }
                //        entries[i].value = values;
                //        version++;
                //        return;
                //    }

                //}
                int index;
                if (freeCount > 0)
                {
                    index = freeList;
                    freeList = entries[index].next;
                    freeCount--;
                }
                else
                {
                    if (count == entries.Length)
                    {
                        Resize();
                        targetBucket = hashCode % buckets.Length;
                    }
                    index = count;
                    count++;
                }

                entries[index].hashCode = hashCode;
                entries[index].next = buckets[targetBucket];
                entries[index].key = keys;
                entries[index].value = values;
                buckets[targetBucket] = index;
                version++;
            }


            public int FindEntry(string keys)
            {
                if (keys == null)
                {
                MessageBox.Show("Bạn chưa nhập từ cần tìm");

                }

                if (buckets != null)
                {
                    int hashCode = GetHashCode(keys);
                    for (int i = buckets[hashCode % buckets.Length]; i >= 0; i = entries[i].next)
                    {
                        if (entries[i].hashCode == hashCode && Comparer.Equals(entries[i].key, keys)) return i;
                    }
                }
                return -1;
            }
   

            private void fmain_Load(object sender, EventArgs e)
            {

            LoadTD();
           int size =Convert.ToInt32(dgvTD.RowCount.ToString());

            Initialize(size);

            string k, v;
            foreach (DataRow dr in dtTD.Rows)
            {
                k = dr["Tu"].ToString();
                v = dr["Nghia"].ToString();
                Insert(k, v, true);
            }

             }
            //show form Quanly
            private void toolStripMenuItem6_Click(object sender, EventArgs e)
            {
                new Quanly().ShowDialog();
            }

            //hiển thị messagebox chọn  yes/no khi thoát chương trình
            private void toolStripMenuExit_Click(object sender, EventArgs e)
            {

                string message = "Bạn có uốn thoát không ?";
                string caption = "Từ điển Anh-Việt";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {

                    // Closes the parent form.
                    this.Close();
                }
            }

            //xủ lý trên radiobutom
            private void rdvietanh_Click(object sender, EventArgs e)
            {
                if (rdvietanh.Checked)
                {
                    this.rdanhviet.Checked = false;
                }
            }

            private void rdanhviet_Click(object sender, EventArgs e)
            {
                if (rdanhviet.Checked)
                {
                    this.rdvietanh.Checked = false;
                }
            }

        //lấy dữ liệu từ dgv đưa lên txtbox
        private void dgvTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành 
                int r = dgvTD.CurrentCell.RowIndex;
                //Chuyển thông tin lên textbox
                this.tbtratu.Text =
                dgvTD.Rows[r].Cells[0].Value.ToString();
  

                this.label1.Text =
                dgvTD.Rows[r].Cells[1].Value.ToString();


            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //tra từ
        public void Tratu()
        {
            if (tbtratu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ cần tìm");
            }
            else
            {
                int i = FindEntry(tbtratu.Text);
                if (i >= 0)
                {
                    label1.Text = entries[i].value;
                }
                else
                {
                    MessageBox.Show("Từ bạn tìm hiện không có ");

                }
            }
        }
        private void btntratu_Click(object sender, EventArgs e)
        {
            if (tbtratu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ cần tìm");
            }
            else
            {
                int i = FindEntry(tbtratu.Text);
                if (i >= 0)
                {
                    label1.Text = entries[i].value;
                }
                else
                {
                    MessageBox.Show("Từ bạn tìm hiện không có ");

                }
            }
        }

        private void btnthemtuvung_Click(object sender, EventArgs e)
        {
            new Quanly().ShowDialog();
        }

        private void btnnghe_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            voice.Speak(tbtratu.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }


        private void tbtratu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public int GetHashCode(String key)
        {
            // Never change this hash function.  We must standardize it so that 
            // others can read & write our .resources files.  Additionally, we
            // have a copy of it in InternalResGen as well.
            uint hash = 5381;
            for (int i = 0; i < key.Length; i++)
                hash = ((hash << 5) + hash) ^ key[i];
            return (int)hash & 0x7FFFFFFF;

        }
        public void Resize()
        { }


        //private void tbtratu_KeyDown(object sender, KeyEventArgs e)
        //{

        //}
    }
}