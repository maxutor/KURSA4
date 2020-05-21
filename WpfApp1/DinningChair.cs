using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Dining_chair : Chair
    {
        protected string Soft_seat { get; set; }
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }
        
        public Dining_chair(
                     string name_of_chair,
                     int price,
                     int count_of_product = 0,
                     string color = "unknown",
                     double width = 0.0,
                     double height = 0.0,
                     double depth = 0.0,
                     double seat_w = 0.0,
                     double seat_h = 0.0,
                     double seat_d = 0.0,
                     string materials = "Strange mix of materials",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg",
                     string soft_seat = "yes")
            : base(
                  name_of_chair,
                  price,
                  count_of_product,
                  color, width, height,
                  depth,
                  seat_w,
                  seat_h,
                  seat_d)
        {
            Soft_seat = soft_seat;
            ImagePath = imagePath;
            Materials = materials;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                "Dining chairs don’t just have to feel good when you sit on them,\n" +
                "they need to look good, too. Ours have the right proportions to be\n" +
                "comfortable, even if you like to linger over dessert. They come in\n" +
                "different styles so you can find what best suits you.\n";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Soft seat?: {Soft_seat} || Has legs?: {Has_legs()}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
