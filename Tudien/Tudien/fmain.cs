#define MAX
#undef MAX 
#define TUDIEN
#define data

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


namespace Tudien
{
     public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();

        }
        //tạo class từ điển
        //class TUDIEN
        // {
        //     public char[] Tu; //từ
        //     public char[] Nghia;//nghĩa của từ 
        //     public char[] LoaiTu;//loại từ

        //     public TUDIEN(char[] Tu, char[] Nghia, char[] LoaiTu)
        //     {
        //         this.Tu = Tu;
        //         this.Nghia = Nghia;
        //         this.LoaiTu = LoaiTu;
        //     }
        //     public char[] tu
        //     {
        //         get { return Tu; }
        //     }
        //     public char[] nghia
        //     {
        //         get { return Nghia; }
        //     }
        //     public char[] loaitu
        //     {
        //         get { return LoaiTu; }
        //     }
        // }

        //tiếp theo là định nghĩa một node
        //class Node
        //{
        //    public TUDIEN Data;
        //    public Node Next;

        //    public Node[] Bucket=new Node[26];

        //    public Node(TUDIEN data, Node next)
        //    {
        //        this.Data = Data;
        //        this.Next = Next;
        //    }
        //    public Node()
        //    {
        //        this.Data = null;
        //        this.Next = null;
        //    }
        //    public TUDIEN data
        //    {
        //        get { return Data; }
        //        set { Data = value; }
        //    }
        //    public Node next
        //    {
        //        get { return Next; }
        //        set { Next = value; }
        //    }
        //}

        // Khởi tạo thùng bucket 

            //
        public Node[] Bucket = new Node[26];
        void Initialize()
        {
            for (int b = 0; b <26; b++)
                Bucket[b] = null;
        }
        //kiem tra bucket b co rong khong
        bool EmptyBucket(int b)
        {
            return (Bucket[b] == null ? true : false);
        }
        //hàm băm
        int Hashfunc(char[] Tu)
        {
            char ch = Char.ToUpper(Tu[0]);
            return ((ch - 65) % 26);
        }

        private void fmain_Load(object sender, EventArgs e)
        {

        }
    }
}
