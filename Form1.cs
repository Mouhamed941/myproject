using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_OOP_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Events (Olaylar) kullanıcının fare ile tıklaması, klavyeden bir tuşa basma gibi işletim sistemi üzerinden gerçekleştirdiği eylemlerdir. Bir bileşen üzerinde meydana gelen olayları takip eden ve bunları yakalayan mekanizma event handler olarak adlandırılır. 

        // Event Handler ilgili olay gerçekleştiği zaman tetiklenir. Olay gerçekleştikten sonra hangi işlemlerin yapılacağı olay yöneticileri için delegeler ile temsil edilir. Bir kullanıcının fare ile tıklaması örneğin bir Click olayıdır, bir tuşa basma olayı bir Keypress olayıdır ve bu olayların sonucunda nelerin yapılması gerektiğini biz kodlarımızla belirtebiliriz.
        private void button1_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();
            // Tıpkı delegelerde olduğu gibi bir olayı bir metota bağlamak için "+=" çıkarmak için ise "-=" kullanılır.

            // Yalnız bu noktada dikkat edilmesi gereken durum, olayların bağlanacağı metotların imza yapıları olayın türü olan delege ile aynı olmalıdır. Buradan tabi şunu da anlayabiliriz. Bir eventten önce mutlaka bir delege tanımlanmalıdır. Event önünce access modifier tanımlanabilir, public, private, protected, internal, abstract, new override, static, virtual gibi.

            Araba araba = new Araba(70, "BMW");
            araba.HizAsimi += new HizAsimiEventHandler(HizLimit);

            for (int i = 0; i < 7; i++)
            {
                araba.Hiz += 10;
                lstSonuc.Items.Add("Arabanın şuanki hızı : " + araba.Hiz);
            }
        }

        void HizLimit()
        {
            lstSonuc.Items.Add("Araç Hız Limitini Aştı !!!!!");
        }
    }
}

