using System;

namespace CW3
{
    public class Queue3
    {
        private int front, rear, capacity;
        private Object[] array;

        public Queue3()
        {
            front = rear = 0;
            capacity = 100;
            array = new Object[capacity];
        }

        public void Enqueue(Object value)
        {
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }
            else
            {
                array[rear] = value;
                rear++;
            }
        }
        public Object Dequeue()
        {
            if (front == rear)
            {
                return new Object();
            }
            else
            {
                Object obj;
                obj = array[0];
                for (int i = 0; i < rear - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                if (rear < capacity)
                    array[rear] = 0;
                rear--;

                return obj;
            }
        }
    }
}
