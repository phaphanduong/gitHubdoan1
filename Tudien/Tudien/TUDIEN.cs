using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudien
{
   public class TUDIEN
    {
        public char[] Tu; //từ
        public char[] Nghia;//nghĩa của từ 
        public char[] LoaiTu;//loại từ

        public TUDIEN(char[] Tu, char[] Nghia, char[] LoaiTu)
        {
            this.Tu = Tu;
            this.Nghia = Nghia;
            this.LoaiTu = LoaiTu;
        }
        public char[] tu
        {
            get { return Tu; }
        }
        public char[] nghia
        {
            get { return Nghia; }
        }
        public char[] loaitu
        {
            get { return LoaiTu; }
        }
    }
}
