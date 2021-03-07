using System;

namespace Observer.ShoppingMall
{
    public interface IObservervable
    {
        void AddSubscriber(IObserver subscriber);

        void DeleteSubscriber(IObserver subscriber);

        void NotifySubscribers(ObserverContextType type);
    }
}
