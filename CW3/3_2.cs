using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    public class Queue1 : ArrayList
    {
        public void Enqueue(Object value) 
        {
            this.Add(value);
        }
        public Object Dequeue()
        {
            if (this.Count > 0)
            {
                Object obj = this[0];
                this.RemoveAt(0);
                return obj;
            }
            else
                return new Object();
        }
    }

    public class Queue2
    {
        private ArrayList array;
        public Queue2()
        {
            array = new ArrayList();
        }
        public void Enqueue(Object value)
        {
            array.Add(value);
        }
        public Object Dequeue()
        {
            if (array.Count > 0)
            {
                Object obj = array[0];
                array.RemoveAt(0);
                return obj;
            }
            else
                return new Object();
        }
    }
}
