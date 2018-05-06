using System;
using System.Collections.Generic;
using System.Linq;


namespace Aufgabe4_Generic_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand111 = tree.CreateNode("grand111");
            var grand112 = tree.CreateNode("grand112");
            grand11.AppendChild(grand111);
            grand11.AppendChild(grand112);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree();

            foreach (var element in root.FindChild("grand111"))
            {
                Console.WriteLine(element);
            }
        }
    }    
     public class TreeNode<T>
    {
        public T Data;
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();

        public TreeNode<T> CreateNode(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>
            {
                Data = data
            };
            return newNode;
        }

        public void AppendChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public void RemoveChild(TreeNode<T> child)
        {
            Children.Remove(child);
        }

        public void PrintTree(String AddTree = "")
        {
            Console.WriteLine(AddTree + Data);
            foreach (TreeNode<T> child in Children)
            {
                child.PrintTree(AddTree + "*");
            }
        }

        public List<TreeNode<T>> FindChild(T search, List<TreeNode<T>> Nodes = null)
        {
            if (Nodes == null)
            {
                Nodes = new List<TreeNode<T>>();
            }
            if (Data.Equals(search))
            {
                Nodes.Add(this);
            }
            foreach (TreeNode<T> child in Children)
            {
                child.FindChild(search, Nodes);
            }
            return Nodes;
        }
        
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}