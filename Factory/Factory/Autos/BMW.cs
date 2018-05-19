using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory.Autos
{
    class BMW : IAuto
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException();
            Name = name;
        }

        public void TurnOff()
        {
           MessageBox.Show(string.Format("Screech! The {0} car comes to a halt and is shutting down", Name));
        }

        public void TurnOn()
        {
            MessageBox.Show(string.Format("Vrrooom! The {0} car is up and running", Name));
        }
    }
}
