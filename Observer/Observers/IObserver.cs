using System;

namespace Observer.ShoppingMall
{
    public interface IObserver
    {
        void Notify(ObserverContextType type);
    }
}
