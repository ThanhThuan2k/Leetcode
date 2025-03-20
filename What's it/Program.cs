// See https://aka.ms/new-console-template for more information

using System;
using What_s_it.LeetCode;

// Code

// Tạo danh sách liên kết từ mảng
ListNode l1 = Helper.CreateLinkedList(new int[] { 9, 9, 9, 9, 9 });
ListNode l2 = Helper.CreateLinkedList(new int[] { 9, 9, });

// Gọi hàm cộng hai số
ListNode result = MySolution.AddTwoNumbers(l1, l2);

// In danh sách kết quả
Helper.PrintLinkedList(result);
