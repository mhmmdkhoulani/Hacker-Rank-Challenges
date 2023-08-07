
using static Solution;

namespace RemoveNodeAtPositionLL
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

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist1, " ");
            Console.WriteLine();

        }
        public static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
        {
            SinglyLinkedListNode node = llist;
            SinglyLinkedListNode temp = llist;
            if (position > 0)
            {
                for (int i = 0; i < position - 1; i++)
                {
                    if (node.next != null)
                        node = node.next;
                }
                temp = node.next;
                node.next = null;
                node.next = temp.next;
                return llist;
            }
            else
            {
                temp = node.next;
                
                return temp;
            }
        }
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
