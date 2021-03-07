using System;

namespace Observer.ShoppingMall
{
    public class IncomeProductObserver : IObserver
    {
        public void Notify(ObserverContextType type)
        {
            if (type != ObserverContextType.IncomeProduct)
            {
                return;
            }

            Console.WriteLine("Shop: income new products.");
        }
    }
}
