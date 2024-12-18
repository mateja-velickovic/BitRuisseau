using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataModel.Catalog;

namespace Frontend
{
    public class EnergyManager
    {
        public PCS100_UPS_I UPS = new PCS100_UPS_I("UP29418512", "UPS");

        double currentEnergy = 0;
        public double _currentEnergy { get => currentEnergy; set => currentEnergy = value; }

    }
}
