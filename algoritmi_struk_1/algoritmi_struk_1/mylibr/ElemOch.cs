using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmi_struk_1
{    
    //элемент очереди в виде класса
    class ElemOch
    {   //поля
       public InfElem data;  //информац поле
       public ElemOch L;     //ссылка на след обьект

        //конструктор без параметра
        public ElemOch():base()
        {
            L = null;
        }

        //конструктор с парамметром
        public ElemOch(InfElem data)
        {
            this.data = data;
            L = null;

        }

        //вывод информации (полей структуры InfElem) в виде строки
        public override string ToString()
        {
            return data.Tostring();////////////////////////////////////////////////////////
        }

    }
}
