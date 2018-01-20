using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Kuyruk
{
   public class DaireselKuyruk:IKuyruk
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public DaireselKuyruk(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Kuyruk dolu.");

            if (front == -1)
                front = 0;

           
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
                Queue[++rear] = o;

            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Kuyruk boş.");

            object temp = Queue[front];
            Queue[front] = null;

           
            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;

            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
