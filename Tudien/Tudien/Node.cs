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

        //public Node(TUDIEN data, Node next)
        //{
        //    this.Data = Data;
        //    this.Next = Next;
        //}
        //public Node()
        //{
        //    this.Data = null;
        //    this.Next = null;
        //}
        //public TUDIEN data
        //{
        //    get { return Data; }
        //    set { Data = value; }
        //}
        //public Node next
        //{
        //    get { return Next; }
        //    set { Next = value; }
        //}

        //public class MyLinkedList
        //{
        //    Node head;

        //    //them một phần tử vào danh sách lien kết
        //    public Node AddNodes(char[] Tu,char[] Nghia, char[] Loaitu)
        //    {
        //        Node node = new Node();

        //        if (node.Next == null)
        //        {
        //            node.Data.Tu = Tu;
        //            node.Data.Nghia = Nghia;
        //            node.Data.LoaiTu = Loaitu;
        //            node.Next = head;
        //            head = node;
        //        }
        //        else
        //        {
        //            while (node.Next != null)
        //                node = node.Next;

        //            node.Data.Tu = Tu;
        //            node.Data.Nghia = Nghia;
        //            node.Data.LoaiTu = Loaitu;
        //            node.Next = null;

        //        }
        //        return node;
        //    }
        //}

        //public class DictionaryEntry<TKey, TValue>
        //{
        //    public readonly int hashCode;
        //    public readonly int next;
        //    public readonly TKey key;
        //    public readonly TValue value;

        //    public DictionaryEntry(int hashCode, int next, TKey key, TValue value)
        //    {
        //        this.hashCode = hashCode;
        //        this.next = next;
        //        this.key = key;
        //        this.value = value;
        //    }

        //    public int HashCode
        //    {
        //        get { return hashCode; }
        //    }

        //    public int Next
        //    {
        //        get { return next; }
        //    }

        //    public TKey Key
        //    {
        //        get { return key; }
        //    }

        //    public TValue Value
        //    {
        //        get { return value; }
        //    }
        //}
    }
}
