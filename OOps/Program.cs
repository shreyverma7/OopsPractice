using OOps.CommercialDataProcessing;
using OOps.InventoryManagement;
using OOps.StockAccountManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;
using System.Security.AccessControl;

internal class Program

{
    
    static string invertory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\StockAccountManagement\CompanyStock.json";

    static string invertory_filePath_Customer = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\CommercialDataProcessing\CustomerStock.json";
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Welcome to CommercialData Processsing -->");

        Console.WriteLine("\n");
        Console.WriteLine("Enter The amount");
        int amount = Convert.ToInt32(Console.ReadLine());
        StockOperation details = new StockOperation();   
        CustomerStockOperation cusStu = new CustomerStockOperation();

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter input :\n1.See all stock \n2.Buy new Stock \n3.Sell existing stock \n4.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Company Stock Details");
                    details.ReadStockJson(invertory_filePath);
                    Console.WriteLine("\nCustomer Stock Details");
                    cusStu.ReadCustomerStock(invertory_filePath_Customer);
                    cusStu.CustomerStockoperation(amount);

                    break;
                case 2:
                    Console.WriteLine("\n Buy Stock");
                    cusStu.CustomerBuyStockFromCompany();
                     cusStu.WriteToCompanyFile(invertory_filePath);
                    cusStu.WriteToCustumerFile(invertory_filePath_Customer); 
                    break;
               
                case 3:
                    Console.WriteLine("Selling stock");
                    cusStu.CustomerSellStockFromCompany();
                    cusStu.WriteToCompanyFile(invertory_filePath);
                    cusStu.WriteToCustumerFile(invertory_filePath_Customer);
                    break;
                case 4:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;



            }
        }
     
       
    }
}