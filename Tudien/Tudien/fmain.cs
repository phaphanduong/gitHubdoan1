
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
        SqlDataAdapter daTD = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtTD = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataView dtvTD = null;
        
        //hàm LoadTD, load dữ liệu lên datagirview khi chương trình chạy
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
                // Đưa dữ liệu lên dgv
                //nếu dữ liệu được hiển thị ra datagridview .Ta cần 1 DataView kết nối đến DataTable .Đối tượng DataView dùng cho việc sắp xếp,lọc, tìm kiếm
                dtvTD = new DataView(dtTD);
                // gán datasource cho datagridview
                dgvTD.DataSource = dtvTD;
                if (rdanhviet.Checked == true)
                {
                    dgvTD.Columns[0].Visible = true;
                    dgvTD.Columns[1].Visible = false;
                }
                else
                {
                    dgvTD.Columns[0].Visible = false;
                    dgvTD.Columns[1].Visible = true;
                }
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

        //khai báo cấu trúc khi luu trữ một từ, gồm có 4 thông tin
            public struct Entry
            {
                public int hashCode;    // giá trị được tính dựa vào mã ASCII của từ, 
                                        //được sử dụng khi xác định vị trí của phần tử trong bảng băm 
                public int next;        // nếu trong cùng một địa chỉ có 2 phần tử được lưu thì biến này sẽ lưu thứ tự của phần tử được thêm vào trước đó
                                        //và = -1 if nếu là phần tử cuối cùng tức là được thêm vào đầu tiên
                public string key;           // từ 
                public string value;         // nghĩa tương ứng
            }
            public int[] buckets;       // khai báo buckets chứa giá trị đã băm của từ và thứ tự được thêm vào
            public Entry[] entries;     // luu trữ các thông tin hashcode, next,key, value của từ
              
        //hàm khởi tạo buckets và entry dựa vào số phần tử hiện có trong database
            public void Initialize(int size)
            {
            //khoi tao mang bucket
            buckets = new int[size];
                for (int i = 0; i < buckets.Length; i++) buckets[i] = -1;       //lưu trữ vị trí của phần tử trong bảng băm
                entries = new Entry[size];      //lưu trữ các giá trị liên quan đến phần tử : key, value, next, hashcode
            }

        //hàm thêm một từ vào bảng băm
            public void Insert(string keys, string values, int count)
            {
                //khởi tạo bucket
                if (buckets == null) Initialize(0);
                //lấy giá trị băm của từ
                int hashCode = GetHashCode(keys)& 0x7FFFFFFF;
            //hàm băm từ để xác định vị trí của từ trong bảng băm
                 int targetBucket =hashCode % buckets.Length;
                int index;
                    index = count;
                    count++;
            //thêm các thông tin liên quan đến phần tử 
                entries[index].hashCode = hashCode;
            //xác định điểm dừng và lưu thông tin về vị trí của entries khi mà 2 entries có cùng địa chỉ mảng trong bucket
                entries[index].next = buckets[targetBucket];
                entries[index].key = keys;
                entries[index].value = values;
            //xác định phần tử nằm ở địa  thứ mấy và thứ tự được thêm vào buckets,
              //nếu 2 phần tử có cùng địa chỉ thì địa chỉ đó sẽ lưu thứ tự của phần tử được thêm vào sau cùng
                buckets[targetBucket] = index;

            }

        //hàm tìm nghĩa của phần tử
            public int FindEntry(string keys)
            {
                if (keys == null)
                {
                MessageBox.Show("Bạn chưa nhập từ cần tìm");

                }
                if (buckets != null)
                {
                    int hashCode = GetHashCode(keys);
                // xác định thứ tự của phần tử, qua đó tìm được thông tin của phần tử trong mảng các entries
                    for (int i = buckets[hashCode % buckets.Length]; i >= 0; i = entries[i].next)
                    {
                    //kiểm tra xem hashcode của từ đó với key có giống nhau không
                        if (entries[i].hashCode == hashCode && Comparer.Equals(entries[i].key, keys)) return i;
                    }
                }
                return -1;
            }
   
        //sự kiện fmain_Load khi form được load lên sẽ lấy thông tin từ database đưa lên datagirview
            private void fmain_Load(object sender, EventArgs e)
            {
                 int c = 0;
                LoadTD();
                //lấy số lựơng từ để khởi tạo kích thước bảng băm
                int size = Convert.ToInt32(dgvTD.RowCount.ToString())-1;
                Initialize(size);

                string k, v;
                //lấy từng phần tử trong dataTable để thêm vào bảng băm
                foreach (DataRow dr in dtTD.Rows)
                {
                    k = dr["Tu"].ToString();  
                    v = dr["Nghia"].ToString();
                //kiểm tra xem người dùng dang dùng chức năng tra từ nào 
                //chức năng tra từ tiếng anh sang việt
                if (rdanhviet.Checked == true)
                {
                    Insert(k, v, c);
                    c++;
                }
                //chức năng tra từ từ viêt sang anh
                else
                {
                    Insert(v,k, c);
                    c++;
                }
                }
             }
        //sự kiện show form Quanly khi click vào  toolStripMenu Quản lý từ diển9
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
            {
            new DangNhap().ShowDialog();
            }

        //hiển thị messagebox chọn  yes/no khiclick vào  toolStripMenu thoát chương trình
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

        //lấy dữ liệu từ dgv đưa lên txtbox
        private void dgvTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //thao tác cho radiobutton anh-viet
                if (rdanhviet.Checked == true)
                {
                    // Thứ tự dòng hiện hành 
                    int r = dgvTD.CurrentCell.RowIndex;
                    //Chuyển thông tin lên textbox
                    //lấy giá trị ở vị trí hiện tại trong cell[0] dưa lên tntratu
                    this.tbtratu.Text =
                    dgvTD.Rows[r].Cells[0].Value.ToString();
                    //lấy giá trị ở vị trí hiện trong cell[1] tại dưa lên lable  nghĩa
                    this.label1.Text =
                    dgvTD.Rows[r].Cells[1].Value.ToString();
                }
                //thao tác cho radiobutton viet-anh
                else if (rdvietanh.Checked == true)
                {
                    // Thứ tự dòng hiện hành 
                    int r = dgvTD.CurrentCell.RowIndex;
                    //Chuyển thông tin lên textbox
                    //lấy giá trị ở vị trí hiện tại trong cell[1] dưa lên tntratu

                    this.tbtratu.Text =
                    dgvTD.Rows[r].Cells[1].Value.ToString();
                    //lấy giá trị ở vị trí hiện trong cell[0] tại dưa lên tntratu

                    this.label1.Text =
                    dgvTD.Rows[r].Cells[0].Value.ToString();
                }


            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //sự kiện button tra từ dược click
        private void btntratu_Click(object sender, EventArgs e)
        {
            if (tbtratu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ cần tìm");
            }
            else
            {
                //lấy được thứ tự của từ được thêm vào bảng băm
                int i = FindEntry(tbtratu.Text);
                //nếu i trả về lớn ơn 0 thì d49 tìm thấy
                if (i >= 0)
                {
                    label1.Text = entries[i].value;
                }
                //không tìm thấy
                else
                {
                    MessageBox.Show("Từ bạn tìm hiện không có ");

                }
            }
        }

        //sự kiện click vào button nghe
        private void btnnghe_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            
            voice.Speak(tbtratu.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        //lấy giá trị của một từ dựa vào bảng mã ascII
        public int GetHashCode(String key)
        {
  

            uint hash = 0;
            for (int i = 0; i < key.Length; i++)
                hash += key[i];     //trả về tổng giá trị các ký tự tróng từ
            return (int)hash & 0x7FFFFFFF;  //thao tác loại bỏ giá trị âm
        }

        //sự kiện loaddata khi click vào button load lại 
        private void btnthemtuvung_Click_1(object sender, EventArgs e)
        {
            LoadTD();
        }

        //sự kiện bôi đen 1 từ khi click vào textbox
        private void tbtratu_MouseClick(object sender, MouseEventArgs e)
        {
            tbtratu.SelectAll();
        }

        //xử lý khi check vào radiobutton anh-viet
        private void rdanhviet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdanhviet.Checked)
            {
                this.rdvietanh.Checked = false;
            }
        }
        //xử lý khi check vào radiobutton viet-anh
        private void rdvietanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdvietanh.Checked)
            {
                this.rdanhviet.Checked = false;
            }
        }


        //xử lý sự kiện khi người dùng chọn chức năng tra từ  anh-viet
        private void rdanhviet_Click(object sender, EventArgs e)
        {
            int c = 0;
       //gọi hàm load để lấy dữ liệu
            LoadTD();
            //lấy số lựơng từ để khởi tạo kích thước bảng băm
            int size = Convert.ToInt32(dgvTD.RowCount.ToString());

            Initialize(size);

            string k, v;
            //lấy từng phần tử trong dataTable để thêm vào bảng băm
            foreach (DataRow dr in dtTD.Rows)
            {
                k = dr["Tu"].ToString();
                v = dr["Nghia"].ToString();
                //thêm phần tử vào bảng băm
                Insert(k, v, c);
                c++;
            }
        }

        //xử lý sự kiện khi người dùng chọn chức năng tra từ  anh-viet
            private void rdvietanh_Click(object sender, EventArgs e)
        {
            int c = 0;
            LoadTD();
            //lấy số lựơng từ để khởi tạo kích thước bảng băm
            int size = Convert.ToInt32(dgvTD.RowCount.ToString());

            Initialize(size);

            string k, v;
            //lấy từng phần tử trong dataTable để thêm vào bảng băm
            foreach (DataRow dr in dtTD.Rows)
            {
                k = dr["Tu"].ToString();
                v = dr["Nghia"].ToString();
                //thêm phần tử vào bảng băm
                Insert(v, k, c);
                c++;
            }
        }
    }
}