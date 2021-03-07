using System;
using System.Collections.Generic;

namespace Observer.ShoppingMall
{
    public class ShoppingMall : IObservervable
    {
        public ShoppingMall()
        {
            this.subsribers = new List<IObserver>();
        }

        public void MakeSell()
        {
            Console.WriteLine("The shop made a sell!");
            NotifySubscribers(ObserverContextType.SellProduct);
        }

        public void IncomeNewProduct()
        {
            Console.WriteLine("Income new products into the shop!");
            NotifySubscribers(ObserverContextType.IncomeProduct);
        }

        public void AddSubscriber(IObserver subscriber)
        {
            subsribers.Add(subscriber);
            Console.WriteLine($"{this.GetType().Name} added subscriber: {subscriber.GetType().Name}.");
        }

        public void DeleteSubscriber(IObserver subscriber)
        {
            subsribers.Remove(subscriber);
            Console.WriteLine($"{this.GetType().Name} deleted subscriber: {subscriber.GetType().Name}.");
        }

        public void NotifySubscribers(ObserverContextType type)
        {
            foreach(var subscriber in subsribers)
            {
                subscriber.Notify(type);
            }
        }

        private List<IObserver> subsribers;
    }
}
