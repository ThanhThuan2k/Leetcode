namespace What_s_it.LeetCode
{
    public static class MySolution
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (seen.ContainsKey(complement))
                {
                    return new int[] { seen[complement], i };
                }
                seen[nums[i]] = i;
            }
            return new int[0];
        }

        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            int carry = 0; // Memory for the next digit

            while (l1 != null || l2 != null || carry > 0)
            {
                int val1 = (l1 != null) ? l1.val : 0;
                int val2 = (l2 != null) ? l2.val : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;
                int digit = sum % 10;

                current.next = new ListNode(digit);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummy.next;
        }


    }

    public static class Helper
    {
        public static ListNode CreateLinkedList(int[] nums)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            foreach (int num in nums)
            {
                current.next = new ListNode(num);
                current = current.next;
            }
            return dummy.next;
        }

        public static void PrintLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val);
                if (head.next != null) Console.Write(" -> ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }

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
}
