using System;

namespace Algorithms
{
   /// <summary>
   /// This is a propsed solution to the question posed in QuestionOne.txt
   /// </summary>
   public class QuestionOne
   {
      public static void Solve()
      {
         int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9 };
         Console.WriteLine(string.Format("Max profit of stock prices yesterday {0}", GetMaxProfitBetter(stockPricesYesterday)));
         Console.ReadKey();
      }
      /// <summary>
      /// This was my initial solution, while simple, it's running time is less than desireable ( O(n^2) )
      /// </summary>
      /// <param name="stockPrices"></param>
      /// <returns></returns>
      private static int GetMaxProfitSlow(int[] stockPrices)
      {
         int maxProfit = 0;
         //at the very least we have to iterate through all the prices in the list
         for (int i = 0; i < stockPrices.Length; i++)
         {
            //grab the price to compute the profit for
            int p = stockPrices[i];
            //iterate through all the prices AFTER p 
            for (int n = i + 1; n < stockPrices.Length; n++)
            {
               //compute the potential profit
               var profit = stockPrices[n] - p;
               if (profit > maxProfit)
                  maxProfit = profit;
            }
         }
         return maxProfit;
      }
      /// <summary>
      /// This solution is more efficent running in O(n), but it will return negative numbers if the stock is continually falling. 
      /// However if you are getting a negative profit it's pretty clear that you should not be buying any of the stock. 
      /// </summary>
      /// <param name="stockPrices"></param>
      /// <returns></returns>
      private static int GetMaxProfitBetter(int[] stockPrices)
      {
         int lowestPrice = stockPrices[0];//start with the first stock price in the list
         int maxProfit = 0;
         //try to iterate through the prices only once, 
         for (int i = 0; i < stockPrices.Length; i++)
         {
            var curPrice = stockPrices[i];
            //compute what our profit is if we sold at current price from the lowest we have seen so far
            var profit = curPrice - lowestPrice;
            if (profit > maxProfit)
               maxProfit = profit;//we improved our profit. 
            //the current price is the lowest we have seen so far so save it. 
            if (curPrice < lowestPrice)
               lowestPrice = curPrice;
         }
         return maxProfit;
      }
   }
}