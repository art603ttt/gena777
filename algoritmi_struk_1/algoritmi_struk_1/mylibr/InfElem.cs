using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmi_struk_1
{   
    //структура для размещения в элементе очереди
    struct InfElem
    {
        //поля
        int kl;       //ключевое поле
        string name;  //информация

      //конструктор с параметром
      public  InfElem(int kl,string name)
        {
            this.name = name;
            this.kl = kl;

        }

      //генерация информации-полей класса
      public  string Tostring()
      {
            return ("/информация= " + name + "/ключ= " + kl.ToString());
      }   

    }
}
