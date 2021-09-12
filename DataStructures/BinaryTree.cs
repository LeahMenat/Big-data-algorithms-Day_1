using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTree<T>
    {
        public T value { get; set; }
        public BinaryTree<T> LeftNode { get; set; }
        public BinaryTree<T> RightNode { get; set; }


        public BinaryTree(T value1, BinaryTree<T> leftNode1, BinaryTree<T> RightNode1)
        {
            this.value = value1;
            this.LeftNode = leftNode1;
            this.RightNode = RightNode1;
        }

        public int FindN_thNodeOfInorderTraversal(int num, ref T value)
        {

            if (this.LeftNode != null)
            {
                num = this.LeftNode.FindN_thNodeOfInorderTraversal(num, ref value);
                //--num;
            }
            if (num == 1)
            {
                value = this.value; 
                return -1;
            }
            if (this.RightNode != null)
                return this.RightNode.FindN_thNodeOfInorderTraversal(num, ref value);
            else
                return --num;
        }
        public bool CheckIfAllLeavesAreAtSameLevel()
        {
            return (CheckTheLevelOfLeaves(this) != -1);
        }

        private static int CheckTheLevelOfLeaves(BinaryTree<T> bnt)
        {
            if (bnt == null)
                return 0;
            int heightL = CheckTheLevelOfLeaves(bnt.LeftNode);
            if (heightL == -1)
                return -1;
            int heightR = CheckTheLevelOfLeaves(bnt.RightNode);
            if (heightL == 0)
                return heightR + 1;
            if (heightR == 0)
                return heightL + 1;
            if (heightL == heightR)
                return heightL + 1;
            return -1;
        }
    }
}