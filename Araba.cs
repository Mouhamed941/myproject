using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_EventHandler
{
    public delegate void HizAsimiEventHandler();
    public class Araba
    {
        public Araba(int hiz, string model)
        {
            this.Hiz = hiz;
            this.Model = model;
        }

        // Yeni bir olay tanımlamak için event deyimi kullanılır. Olayları tetiklemek için ise olayın ismi kullanılmaktadır.
        public event HizAsimiEventHandler HizAsimi;
        private int _Hiz;
        public int Hiz
        {
            get { return _Hiz; }
            set
            {
                _Hiz = value;
                if (value > 120)
                    HizAsimi();
            }
        }

        private string _Model;
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

    }
}
