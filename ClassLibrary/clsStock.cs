using System;
namespace ClassLibrary
{
    public class clsStock
    {
        private int id;
        private string name;
        private int quantity;
        private string type;
        private string remark;
        private string time;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public bool Find(int stockID)
        {
            return true;
        }

        public string Valid(string Id, string name, string quantity,string type, string remark, string time)
        {
            return "";
        }

        public string Type { get => type; set => type = value; }
        public string Remark { get => remark; set => remark = value; }
        public string Time { get => time; set => time = value; }
    }
}
