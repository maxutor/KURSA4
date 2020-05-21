using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    public abstract class Chair
    {
        public int Price { get; set; }
        protected int Count_of_product { get; set; }
        protected int Purchase_quantity { get; set; } = 0;
        public string Name_of_chair { get; set; }
        public string Color { get; set; }
        protected double Width { get; set; }
        protected double Height { get; set; }
        protected double Depth { get; set; }
        protected double Seat_width { get; set; }
        protected double Seat_height { get; set; }
        protected double Seat_depth { get; set; }

        public abstract string ImagePath { get; set; }
        public abstract string Materials { get; set; }

        public Chair(string name_of_chair,
                     int price,
                     int count_of_product = 0,
                     string color = "unknown",
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double seat_w = 0.0,
                     double seat_h = 0.0,
                     double seat_d = 0.0)
        {
            Name_of_chair = name_of_chair;
            Price = price;
            Count_of_product = count_of_product;
            Color = color;
            Width = width;
            Height = height;
            Depth = depth;
            Seat_width = seat_w;
            Seat_height = seat_h;
            Seat_depth = seat_d;
        }

        public void Buy_chair()
        {
            Purchase_quantity += 1;
            Count_of_product -= 1;
        }

        public bool Is_avaible()
        {
            if (Count_of_product > 0)
            {
                return true;
            }
            return false;
        }

        public string Is_unknown(double param)
        {
            if (param == 0)
            {
                return "unknown";
            }
            return Convert.ToString(param);
        }

        protected virtual string Has_legs()
        {
            return "that model has legs";
        }

        public virtual string RenderResponse()
        {
            return $"Count of product: {Count_of_product}\n" +
                $"Color: {Color}\n" +
                $"\tProduct size:\n" +
                $"Width: {Is_unknown(Width)}\t\t|| Seat_width: {Is_unknown(Seat_width)}\n" +
                $"Height: {Is_unknown(Height)}\t\t|| Seat height: {Is_unknown(Seat_height)}\n" +
                $"Depth: {Is_unknown(Depth)}\t\t|| Seat depth: {Is_unknown(Seat_depth)}";
        }

        protected virtual string Model_description()
        {
            return "Default model, nothing special";
        }
    }
}
