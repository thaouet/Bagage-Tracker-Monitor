using System;
using System.Collections.Generic;
using System.Linq;

namespace Bagage
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<BagageInfo>> _observateurs;
        private IObserver<BagageInfo> _observer;

        public Unsubscriber(List<IObserver<BagageInfo>> observateurs, IObserver<BagageInfo> observer)
        {
            this._observateurs = observateurs;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observateurs.Contains(_observer))
                _observateurs.Remove(_observer);
        }
    }
}
