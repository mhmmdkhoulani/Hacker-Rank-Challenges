using static InsterNodeAtTailOfLL.Solution;

namespace InsterNodeAtTailOfLL
{
    internal class Program
    {
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
            {
                SinglyLinkedListNode temp = new SinglyLinkedListNode(data);
                head = temp;
                return head;
            }
                
            else
            {
                SinglyLinkedListNode value = new SinglyLinkedListNode(data);
                var curretnNode = head;
                
                while (curretnNode.next != null)
                {
                    curretnNode = curretnNode.next;
                    
                }
                curretnNode.next = value;
                return head;
            }
            
        }

        static void Main(string[] args)
        {

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
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

            public SinglyLinkedList()
            {
                this.head = null;
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