using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            int count = list.Count;
            LinkedListNode<int> current = list.First;
            for (int a = 0; a < count - 1; a++)
            {
                for (int b = 0; b < count - a - 1; b++)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            int count = list.Count;
            LinkedListNode<int> current = list.First;
            for (int a = 0; a < count - 1; a++)
            {
                for (int b = 0; b < count - a - 1; b++)
                {
                    if (list.First() < current.Next.Value)
                    {
                        int temp = list.First();
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                    }
                }
            }
            return list;
        }
    }
}
