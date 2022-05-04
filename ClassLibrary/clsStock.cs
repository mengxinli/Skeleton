using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStock
    {
        private int id;
        private string name;
        private int quantity;
        private string type;
        private string remark;
        private DateTime time;
        private bool available;
        private static readonly List<string> types = new List<string>
            { "Food","Utils","Others"};

        public clsStock() { }

        public clsStock(int id, string name, int quantity, string type, string remark, DateTime time, bool available)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.type = type;
            this.remark = remark;
            this.time = time;
            this.available = available;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public bool Find(int stockID)
        {
            return true;
        }

        public string Type { get => type; set => type = value; }
        public string Remark { get => remark; set => remark = value; }
        public DateTime Time { get => time; set => time = value; }
        public bool Available { get => available; set => available = value; }

        public string Valid(int id, string name, int quantity, string type, string remark, string time)
        {
            String Error = "";
            if (id <= 0)
                Error += "Id is less or equal to 0 : ";
            if (name.Length > 20)
                Error += "The length of name is greater than 20 : ";
            if (quantity > 500)
                Error += "The quantity should not be more than 500 : ";
            if (!types.Contains(type))
                Error += "The type should be Food, Utils oe Others : ";
            if (remark.Length > 50)
                Error += "Remark is too long : ";
            if (!DateTime.TryParse(time, out _))
                Error += "Time is invalid : ";
            return Error;
        }
    }
}
