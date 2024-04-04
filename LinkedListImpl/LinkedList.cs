using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImpl
{
    public class LinkedList
    {

        internal Node head;

        internal void Add(int data)
        {

            Node node = new Node(data);
            if (this.head == null)
            {
  
              this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;

            }
            Console.WriteLine("{0}  inserted into the linkedlist ", node.data);

        }
            internal void Display()
            {
                Node temp = this.head;
                if(temp== null)
                {
                    Console.WriteLine("Linked List is empty ");
                    return;


                }
                while (temp != null)
                {
                Console.WriteLine(temp.data+" ");
                temp= temp.next;
            }


            }

            public Node InsertAtParticularPosition(int position, int data){

            if (position < 1)
            {
                Console.WriteLine("Invalid Position ");
            }
            if (position == 1)
            {

                var newNode =new Node(data);
                newNode.next = head;

                head = newNode; 
            }
            else
            {
                Node temp = this.head;
                while (position--!=0 && temp != null)
                {

                    if (position == 1)
                    {
                        Node node=new Node(data);
                        node.next = temp.next;
                        temp.next= node;
                        break;

                    }
                    temp = temp.next;
                    
                }
                if (position != 1)
                {
                    Console.WriteLine("position Out Of Range");
                }
               
            }
            return head;

            }

            internal Node RemoveFisrtNode(){

            if(this.head == null)
            {
                return null;
            }
            this.head =this.head.next;
            return this.head;

            }


            internal Node RemovalLastNode()
            {
            if (head == null)
                return null;
            if (head.next == null)
                return null;

            Node newNode = head;
            while (newNode.next != null)
            {
                newNode=newNode.next;
            }
            newNode.next = null;
            return head;
            }
            
        }

    }

