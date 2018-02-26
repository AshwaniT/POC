using System;

namespace DoubleLinkList
{
    public sealed class CircularLinkedList
    {
        public int MaxValue = 0;
        private Node<int> _head;


        private Node<int> _tail;

        public void AddLast(int item, int number)
        {
            // if head is null, then this will be the first item
            if (_head == null)
            {
                AddFirstItem(item, number);
            }
            else
            {
                var newNode = new Node<int>(item, number);
                _tail.Next = newNode;
                newNode.Next = _head;
                newNode.Previous = _tail;
                _tail = newNode;
                _head.Previous = _tail;
            }

        }

        void AddFirstItem(int item, int number)
        {
            _head = new Node<int>(item, number);
            _tail = _head;
            _head.Next = _tail;
            _head.Previous = _tail;
        }

        public Node<int> MooveForwardAndSetValue(int magicNumber)
        {
            var counter = 0;
            var temp = _head;
            while (counter < magicNumber)
            {
                _tail = temp;
                temp = temp.Next;
                _head = temp;
                counter++;
            }
            _head.Value = _head.Value + 1;
            MaxValue = Math.Max(MaxValue, _head.Value);
            return _head;

        }

        public void StartGame()
        {
            _head.Value = MaxValue = 1;
        }
        public Node<int> MooveBackwardAndSetValue(int magicNumber)
        {
            var counter = 0;
            var temp = _head;
            while (counter < magicNumber)
            {
                _head = temp.Previous;
                _tail=  _head.Previous;
                temp = _head;
                
                counter++;
            }
            _head.Value = _head.Value + 1;
            MaxValue = Math.Max(MaxValue, _head.Value);
            return _head;

        }
    }
    public sealed class Node<T>
    {
        public T Value { get;  set; }
        public int  Number { get; set; }
        public Node<T> Next { get; internal set; }
        public Node<T> Previous { get; internal set; }
        internal Node(T item, int _number)
        {
            Value = item;
            Number = _number;
        }
    }

   public class Program
    {
       static CircularLinkedList _playerListNode;
       


        public static int PlayGame(int input1, int input2, int input3)
       {
           _playerListNode = InitializeList(input1);
           var isEven = false;
           var result = 0;
           if (input1 < 3 || input1 > 1000)
           {
               return -1;
           }
           if (input2 < 3 || input2 > 1000)
           {
               return -1;
           }
           _playerListNode.StartGame();
           while (_playerListNode.MaxValue != input2)
           {
               var head = isEven ? _playerListNode.MooveForwardAndSetValue(input3) : _playerListNode.MooveBackwardAndSetValue(input3);
               isEven = head.Value%2 == 0;
               result++;
           }

           return result;
       }

       private static CircularLinkedList InitializeList(int numberOfplayer)
       {
           _playerListNode=new CircularLinkedList();
           for (int i = 1; i <= numberOfplayer; i++)
           {
               _playerListNode.AddLast(0,i);
           }
           
           return _playerListNode;
       }
    }
}
