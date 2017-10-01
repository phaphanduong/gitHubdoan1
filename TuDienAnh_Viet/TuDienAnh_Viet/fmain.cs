using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;    //thư vien phát âm
namespace TuDienAnh_Viet
{
    public partial class fmain : Form
    {

        //1. sử dụng struct định nghĩa một từ
        struct TUDIEN
        {

        }
        struct Node
        {

        }
        struct LIST
        {


        }
        //2.khởi tạo ds liên kết để lưu các khóa trùng key tì cùng 1 ds liên kết
        void InitiList(LIST hastable[], int i)
        {

        }
        //3.Kiềm tra ds rỗng
        int IsemptyList(LIST hastable[], int )
        {

            return 0;
        }
        //4.Tạo một Node mới
        //5.hàm băm
        //6.Chèn một phần tử vào cuối danh sách liên kết
        //7.tìm vị trí một phần tử bằng x trong bảng băm 
        //8.hàm đọc file
        //9.in nghĩa và loại từ của từ tại vị trí p
        //10.hàm tìm , in ra nghĩa và loại từ của từ vừa nhập
        //các hàm chức năng khác


        public fmain()
        {
            InitializeComponent();
        }

        //chức năng phát âm sử dụng thư viện tronn C# SpeechLib
        private void btnnoi_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            voice.Speak(txtTimkiem.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }




    }
}
