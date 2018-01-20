using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Kuyruk
{
   public class Oncelik_Kuyruk2:IKuyruk
    {
        private object[] Queue;
        private int front = -1;
        private int count = 0;
        private int size = 0;

        public Oncelik_Kuyruk2(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Kuyruk dolu");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                Musteri mstr = (Musteri)o;
                
                for (i = count - 1; i >= 0; i--)
                {
                    if (mstr.IslemSuresi < ((Musteri)Queue[i]).IslemSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Kuyruk boş");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
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
