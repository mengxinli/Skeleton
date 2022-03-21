using System;
namespace ClassLibrary
{
    public class clsStock
    {
        private int id;
        private String name;
        private int quantity;
        private String type;
        private String remark;
        private String time;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public bool Find(int stockID)
        {
            return true;
        }

        public string Type { get => type; set => type = value; }
        public string Remark { get => remark; set => remark = value; }
        public string Time { get => time; set => time = value; }
    }
}
