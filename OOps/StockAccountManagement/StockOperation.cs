using Newtonsoft.Json;
using OOPs.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps.StockAccountManagement
{
    public class StockOperation
    {
        public void ReadStockJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            List<Stock> list = JsonConvert.DeserializeObject<List<Stock>>(json);
            foreach (var data in list)
            {
                Console.WriteLine(data.StockName + " " + data.NoOfShares + " " + data.SharePrice);
            }
        }
    }
}
