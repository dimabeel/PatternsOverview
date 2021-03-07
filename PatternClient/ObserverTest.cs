using System;
using System.Collections.Generic;
using Observer.ShoppingMall;

namespace PatternClient
{
    public class ObserverTest
    {
        public void Work()
        {
            var shoppingMall = new ShoppingMall();

            var incomeProductsObserver = new IncomeProductObserver();
            var saleProductsObserver = new SellProductObserver();

            shoppingMall.AddSubscriber(incomeProductsObserver);
            shoppingMall.AddSubscriber(saleProductsObserver);

            shoppingMall.MakeSell();
            shoppingMall.IncomeNewProduct();
            shoppingMall.MakeSell();
            shoppingMall.DeleteSubscriber(saleProductsObserver);
            shoppingMall.MakeSell();
            shoppingMall.IncomeNewProduct();
        }
    }
}