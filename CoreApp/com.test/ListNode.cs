namespace CoreApp.com.test
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class LinkList
    {
        public ListNode Head = null;
        public ListNode Current = null;
        public ListNode Last = null;

        public LinkList()
        {
            
        }
        public void AddLast(int newData)
        {
            ListNode node = new ListNode();
            node.val = newData;
            node.next = null;

            if(Head != null)
            {
                Head.next = node;
            }
            else
            {
                Head = node;
            }
            Last = Current = node;

        }

        public void AddBegin(int newData)
        {
            ListNode node = new ListNode();
            node.val = newData;
            node.next = null;

            if (Head != null)
            {
                Head.next = Current;

            }
            else
            {
                Head = node;
                Last = node;
            }
            Head = Current = node;
        }

        public void TraverseList()
        {
            ListNode temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.val);
                temp = temp.next;
            }

        }

        public void ReverseList()
        {
            ListNode temp = Head;
            ListNode temp1 = null;
            while(temp != Last)
            {
                temp1 = Last.next;
                Last.next = temp;
                Head = Head.next;
                temp.next = temp1;
                temp = Head;
            }
        }
    }
}
