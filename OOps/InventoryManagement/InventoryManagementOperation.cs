using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using OOPs.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps.InventoryManagement
{
    internal class InventoryManagementOperation
    {
        InventoryManagementDetails list;
        public void ReadInventoryJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);

            Display(list.RiceList);
            Display(list.WheatList);
            Display(list.PulseList);

        }
        public void Display(List<InventoryDetails> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.PricePerKg);
            }
        }
        public void AddInventoryManagement(string objectName)
        {
            if (objectName.ToLower().Equals("rice"))
            {
                Console.WriteLine("Enter RiceType , Weight, Price per kg");
                InventoryDetails details = new InventoryDetails()
                {
                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.RiceList.Add(details);
            }
            if (objectName.ToLower().Equals("wheat"))
            {
                Console.WriteLine("Enter WheatType , Weight, Price per kg");
                InventoryDetails details = new InventoryDetails()
                {


                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.WheatList.Add(details);
            }
            if (objectName.ToLower().Equals("pulse"))
            {
                Console.WriteLine("Enter PulseType , Weight, Price per kg");
                InventoryDetails details = new InventoryDetails()
                {
                    Name = Console.ReadLine(),
                    Weight = Convert.ToInt32(Console.ReadLine()),
                    PricePerKg = Convert.ToInt32(Console.ReadLine())
                };
                list.PulseList.Add(details);
            }
        }
        public void WriteToJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filePath, json);
        }

    }
}
