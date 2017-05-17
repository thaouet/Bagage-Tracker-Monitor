using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage
{
    class Program
    {
        static void Main(string[] args)
        {

            BagageTracker provider = new BagageTracker();
            BagageMonitor moniteur1 = new BagageMonitor("Porte Principale");
            BagageMonitor moniteur2 = new BagageMonitor("Porte A1");

            moniteur1.Subscribe(provider);
            moniteur2.Subscribe(provider);

            provider.DechargerBagage(new BagageInfo(10, "TUNIS CARTHAGE", 2));
            provider.DechargerBagage(new BagageInfo(635, "PARIS ORLY", 1));
            provider.DechargerBagage(null);
            provider.FinDechargementBagage();

            Console.ReadLine();
        }
    }
}
