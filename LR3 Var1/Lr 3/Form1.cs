using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Tovar> Tovars = new List<Tovar>();
            Tovars.Add(new Tovar("Сталь", 230, "Германия", "23"));
            Tovars.Add(new Tovar("Чугун", 610, "Россия", "73"));
            Tovars.Add(new Tovar("Полиэтилен", 90, "Испания", "56"));
            Tovars.Add(new Tovar("Стеатитовая керамика", 570, "Индия", "30"));
            Tovars.Add(new Tovar("Металлические композиты", 1350, "Китай", "78"));
        }
    }
}
