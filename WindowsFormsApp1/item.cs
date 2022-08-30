using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Item
    {
       static List<Item> item = new List<Item>();

        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }
        public int result = 0;
       
       static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6QAMF1U;Initial Catalog=c#Database;Integrated Security=True");

        public void save()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6QAMF1U;Initial Catalog=c#Database;Integrated Security=True");
            string query1 = "insert into Product values('" + this.number + "','" + this.Name + "','" + this.quantity + "','" + this.price + "','" + this.date + "','" + this.inventoryNumber + "','" + this.isAvailable + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query1, conn);
            result = cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public static List<Item> getAllProduct()
        {
            List<Item> it = new List<Item>();

            string query2 = " select *from Product";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query2, conn);
          var res= cmd.ExecuteReader();
            while (res.Read())
            {
                Item i = new Item();
                i.number = Convert.ToInt32(res[0]);
                i.Name = res[1].ToString();
                i.quantity = Convert.ToInt32(res[2]);
                i.price = Convert.ToInt32(res[3]);
                i.date = res[4].ToString();
                i.inventoryNumber = Convert.ToInt32(res[5]);
                i.isAvailable = Convert.ToBoolean(res[6]);
                
                it.Add(i);

            };

            conn.Close();
             return it;
        }

        public static Item find(string Name)
        {
            return item.Find(i => i.Name == Name);

        }
    }
}
