using System;

namespace Observer.ShoppingMall
{
    public class SellProductObserver : IObserver
    {
        public void Notify(ObserverContextType type)
        {
            if (type != ObserverContextType.SellProduct)
            {
                return;
            }

            Console.WriteLine("Shop: was made a sell.");
        }
    }
}
