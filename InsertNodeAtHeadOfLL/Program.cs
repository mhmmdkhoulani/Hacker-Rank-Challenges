using static InsertNodeAtHeadOfLL.Solution;

namespace InsertNodeAtHeadOfLL
{
    internal class Program
    {
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            var value = new SinglyLinkedListNode(data);
            if (llist == null)
            {
                
                llist = value;


                return llist;
            }
            else
            {
                var temp = llist;

                llist = value;
                llist.next = temp;
                return llist;
            }
           
        }

        static void Main(string[] args)
        {

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }



            PrintSinglyLinkedList(llist.head, "\n");
            Console.WriteLine();

        }
    }

    public class Solution
    {

        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

        }

        public static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }
    }
}