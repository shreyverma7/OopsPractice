using Newtonsoft.Json;
using OOps.StockAccountManagement;
using OOPs.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOps.CommercialDataProcessing
{
    public class CustomerStockOperation
    {
        List<Stock> companyStock = new List<Stock>();
        List<CustomerStocks> customerStocks = new List<CustomerStocks>();
        public int amount;
        public void CustomerStockoperation(int amount) {
            this.amount = amount;
            Console.WriteLine("Your Amount : "+ amount);

        }

        public void ReadCompanyStock(String filePath)
        {
            var json = File.ReadAllText(filePath);
            companyStock = JsonConvert.DeserializeObject<List<Stock>>(json);
            foreach (var data in companyStock)
            {
                Console.WriteLine(data.StockName + " " + data.NoOfShares + " " + data.SharePrice);
            }
        }
        public void ReadCustomerStock(String filePath)
        {
            var json = File.ReadAllText(filePath);
            customerStocks = JsonConvert.DeserializeObject<List<CustomerStocks>>(json);
            foreach (var data in customerStocks)
            {
                Console.WriteLine(data.StockSymbol + " " + data.NoOfShares + " " + data.SharePrice);
            }

        }
        public void CustomerSellStockFromCompany()
        {
            Console.WriteLine("Enter the stock Name to Sell");
            string stockname = Console.ReadLine();
            Console.WriteLine("Enter No of shares");
            int shares = Convert.ToInt32(Console.ReadLine());
            CustomerStocks sellCustomerstock = new CustomerStocks();
            foreach (var data in customerStocks)
            {
                if (data.StockSymbol.Equals(stockname))
                {
                    sellCustomerstock = data;
                    if (data.NoOfShares - shares >= 0)
                    {
                        data.NoOfShares -= shares;
                        this.amount += data.SharePrice * shares;
                    }
                    else
                    {
                        Console.WriteLine(" Not have Shares");
                    }
                }
            }
        }
        public void CustomerBuyStockFromCompany()
        {
            Console.WriteLine("Enter the Stock name to buy");
            string stockName = Console.ReadLine();
            Console.WriteLine("Enter no of shares");
            int shares = Convert.ToInt32(Console.ReadLine());   
            Stock buyStock = new Stock();
            foreach (var data in companyStock)
            {
                if (data.StockName.Equals(stockName))
                {
                    buyStock = data;
                    if (data.NoOfShares >= shares && data.SharePrice * shares <= this.amount)
                    {
                        data.NoOfShares -= shares;
                        this.amount -= data.SharePrice * shares;
                    }
                    else
                    {
                        buyStock = null;
                    }
                }
            }
            if(buyStock == null)
            {
                Console.WriteLine("Stock Name doesn't exists");
            }
            else
            {
                CustomerStocks buycustomerStock  = new CustomerStocks();
                foreach (var stock in customerStocks) {
                    if (stock.StockSymbol.Equals(stockName))
                    {
                        buycustomerStock = stock;
                        stock.NoOfShares += shares;
                    }
                }
                if (buycustomerStock == null)
                {
                    buycustomerStock.StockSymbol = stockName;
                    buycustomerStock.NoOfShares = shares;
                    buycustomerStock.SharePrice = buyStock.SharePrice;
                    customerStocks.Add(buycustomerStock);
                }
            }
        }
        public void WriteToCompanyFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(companyStock);
            File.WriteAllText(filePath, json);

        }
        public void WriteToCustumerFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(customerStocks);
            File.WriteAllText(filePath, json);

        }

    }
}
