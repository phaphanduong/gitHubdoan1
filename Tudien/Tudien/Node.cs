using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudien
{
   public class Node
    {

        public TUDIEN Data;
        public Node Next;

        //public Node[] Bucket = new Node[26];

        public Node(TUDIEN data, Node next)
        {
            this.Data = Data;
            this.Next = Next;
        }
        public Node()
        {
            this.Data = null;
            this.Next = null;
        }
        public TUDIEN data
        {
            get { return Data; }
            set { Data = value; }
        }
        public Node next
        {
            get { return Next; }
            set { Next = value; }
        }
    }
}
