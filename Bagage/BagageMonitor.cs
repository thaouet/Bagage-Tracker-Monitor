using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage
{
    class BagageMonitor : IObserver<BagageInfo>
    {
        private String nom;
        private IDisposable unsubscriber;

        public BagageMonitor(string nom)
        {
            this.nom = nom;
        }

        public string Nom
        {  get     { return nom; } }

        public virtual void Subscribe(IObservable<BagageInfo> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }


        public void OnCompleted()
        {
            Console.WriteLine("Fin  Dechargement Bagages {0}.", this.nom);
            this.Unsubscribe();

        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: Bagage Non Determiné.", this.nom);
        }

        public void OnNext(BagageInfo value)
        {
            Console.WriteLine("Informations d'arrivées: " + this.nom);
            Console.WriteLine("Bagage Venant de {0}, VolNumero {1} , Tapis N° {2}", value.Origine, value.NumeroVol, value.Carrousel);
        }
    }
}
