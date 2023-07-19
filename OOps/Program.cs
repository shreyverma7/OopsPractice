using OOps.InventoryManagement;
using OOPs.DataInventoryManagement;
using System.Collections.Generic;

internal class Program
{
    //------>Object of list
    static string inventory_filePath = @"D:\Bridgelabz Problem statement\OopsPractice\OOps\InventoryManagement\InventoryMangementData.json";
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Inventory Management");
        InventoryManagementOperation details = new InventoryManagementOperation();
        details.ReadInventoryJson(inventory_filePath);
        details.AddInventoryManagement("rice");
        details.WriteToJsonFile(inventory_filePath);
    }
}