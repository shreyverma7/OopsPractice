using OOps.InventoryManagement;
using OOps.StockAccountManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;
using System.Security.AccessControl;

internal class Program

{
    //------>List of Object
    // static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\DataInventoryManagement\InventoryData.json";
    //------>Object of list
    //static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\InventoryManagement\InventoryMangementData.json";
    static string invertory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\StockAccountManagement\CompanyStock.json";
    private static void Main(string[] args)
    {
        //List of Object
        //InventoryDetailsOperation details = new InventoryDetailsOperation();
        //details.ReadInventoryJson(inventory_filePath);

        //Object of List
        //InventoryManagementOperation details = new InventoryManagementOperation();

        Console.WriteLine("Welcome to Stock Account Management -->");
        StockOperation details = new StockOperation();
        details.ReadStockJson(invertory_filePath); 


      /*  bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter input :\n1.Reading Inventory \n2.Adding to inventory \n3.Delete \n4.Save \n5.Edit \n6.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Reading Inventory :");
                    details.ReadInventoryJson(inventory_filePath);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("Enter crop to added: Type Rice (or) Wheat (or) Pulse");
                    string input = Console.ReadLine();
                    Console.WriteLine("Adding " + input);
                    details.AddInventoryManagement(input);
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine("Enter the crop name to delete :");
                    string Crops = Console.ReadLine();
                    Console.WriteLine("Enter the data on " + Crops + " To delete :");
                    string data = Console.ReadLine();
                    details.DeleteInventoryItems(Crops, data);
                    details.WriteToJsonFile(inventory_filePath);
                    Console.WriteLine("\n");
                    break;
                case 4:
                    Console.WriteLine("To save changes in Json");
                    details.WriteToJsonFile(inventory_filePath);
                    break;
                case 5:
                    Console.WriteLine("Enter the crop name to edit :");
                    string Crops1 = Console.ReadLine();
                    Console.WriteLine("Enter the data on " + Crops1 + " To edit :");
                    string data1 = Console.ReadLine();
                    details.EditInventoryItems(Crops1, data1);
                    details.WriteToJsonFile(inventory_filePath);
                    Console.WriteLine("Edited Successfully");
                    break;
                case 6:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;



            }
        }
      */
       
    }
}