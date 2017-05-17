using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage
{
  public  class BagageTracker : IObservable<BagageInfo>
    {

        private List<IObserver<BagageInfo>> observers;

        public BagageTracker()
        {
            observers = new List<IObserver<BagageInfo>>();
        }
        
        public IDisposable Subscribe(IObserver<BagageInfo> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers,observer);

        }

        public void DechargerBagage(BagageInfo bagage)
        {
            foreach (var observer in observers)
            {
                if (bagage == null)
                    observer.OnError(new BagageInfoUnknownException());
                else
                    observer.OnNext(bagage);
            }
        }

        public void FinDechargementBagage()
        {
            foreach (var observer in observers.ToArray())
            {
                if (observers.Contains(observer))
                    observer.OnCompleted();
            }
          observers.Clear();
        }

    }


}
