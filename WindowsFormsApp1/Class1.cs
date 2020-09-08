using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        public int Idade { get; set; }
        public string Name { get; set; }
        public int CPF { get; private set; }

        public void Mostrar()
        {
            System.Windows.Forms.MessageBox.Show("o meu nome é " + Name);
        }

    }
}
