using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory.Autos;
using Factory.Factories;

namespace FactoryForm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            //Hard code to BMW for now
            IAutoFactory autoFactory = new BMWFactory();
            IAuto car = autoFactory.CreateAutomobile();
            car.TurnOn();
            car.TurnOff();
        }
    }
}
