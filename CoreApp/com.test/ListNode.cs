namespace CoreApp.com.test
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
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
            node.Val = newData;
            node.Next = null;

            if(Head != null)
            {
                Head.Next = node;
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
            node.Val = newData;
            node.Next = null;

            if (Head != null)
            {
                Head.Next = Current;

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
                Console.WriteLine(temp.Val);
                temp = temp.Next;
            }

        }

        public void ReverseList()
        {
            ListNode temp = Head;
            ListNode temp1 = null;
            while(temp != Last)
            {
                temp1 = Last.Next;
                Last.Next = temp;
                Head = Head.Next;
                temp.Next = temp1;
                temp = Head;
            }
        }
    }
}
