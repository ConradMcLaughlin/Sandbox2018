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
using System.Reflection;

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
            //IAutoFactory autoFactory = new BMWFactory();
            IAutoFactory autoFactory = LoadAutoFactory(txtCarType.Text);
            IAuto car = autoFactory.CreateAutomobile();
            car.TurnOn();
            car.TurnOff();
        }

        IAutoFactory LoadAutoFactory(string autoFactoryName)
        {
            //TODO: Get from factory assembly
            //return Assembly.GetAssembly(typeof(IAutoFactory)).CreateInstance(autoFactoryName) as IAutoFactory;

            //Hard code to BMW for now
            return new BMWFactory();
        }    
    }
}
