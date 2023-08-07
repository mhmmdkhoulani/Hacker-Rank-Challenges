using static InsertNodeAtPostionInLL.Solution;

namespace InsertNodeAtPostionInLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ");
            Console.WriteLine();

        }
        public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
             SinglyLinkedListNode new_node = new SinglyLinkedListNode(data);
        SinglyLinkedListNode temp = llist;
        SinglyLinkedListNode temp2 = llist;
        for(int i =0 ;i < position - 1 ; i++){
            temp = temp.next;
            
        }
        temp2 = temp.next;
        temp.next = new_node;
        temp = temp.next;
        temp.next = temp2;
            return llist;
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

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
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