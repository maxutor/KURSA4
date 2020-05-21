using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cafe_chair : Dining_chair
    {
        string Another_color { get; set; }
        public Cafe_chair(
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
                     string materials = "plastic",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg",
                     string soft_seat = "yes",
                     string another_color = "no"
                    )
            : base(
                  name_of_chair,
                  price,
                  count_of_product,
                  color, width, height,
                  depth,
                  seat_w,
                  seat_h,
                  seat_d,
                  materials,
                  imagePath,
                  soft_seat)
        {
            Another_color = another_color;
        }

        protected override string Model_description()
        {
            return "Description of model:\n" +
                "Perfect option for a summer terrace.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Soft seat?: {Soft_seat} || Has legs?: {Has_legs()}\n" +
                $"Has another color?: {Another_color}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
