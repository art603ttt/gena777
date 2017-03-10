using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmi_struk_1
{   //описание очереди в виде класса
    class MyOch
    {
        //поля
      public  ElemOch H; //начало очереди
      public  ElemOch F; //конец очереди
        
        //конструктор
        public MyOch() : base()
        {
            H = null;
            F = null;
        }

        //проверка,пустая ли очередь
        public bool Empty()
        {
            return (H == null );
        }

        //добавление элемента
        public void AddOch(InfElem data)
        {
            ElemOch p = new ElemOch(data);

            if (Empty())
            {
                H = p;
                F = p;
            }
            else
            {
                F.L = p;
                F = p;
            }
        }

        //удаление элемента
        public void DelOch()
        {
            if (!Empty()) H = H.L;

        }

        //показ первый елемент
        public ElemOch First()
        {
            if (Empty())
            { throw new Exception("Очередь пустая-первого элемента нет!!");
            }
            else { return H; }

        }

        //показать очередь
        public void Show(ref ListBox TBX)
        {
            TBX.Items.Clear();

            ElemOch p = H;

            if (Empty())
            { TBX.Items.Add("Пустая очередь");
            }
            else
            {
                while (p != null)
                {
                    TBX.Items.Add(p.ToString());
                    
                    p = p.L;
                }
            }
        }


    }
}
