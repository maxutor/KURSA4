using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Pads_chair : Chair
    {
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }

        public Pads_chair(
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
                     string materials = "Strange synthetic",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg")
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
            Materials = materials;
            ImagePath = imagePath;
        }

        protected override string Has_legs()
        {
            return "model without legs";
        }

        protected override string Model_description()
        {
            return "You cook great food, but comfortable seating is needed\n" +
                "to enjoy it to the fullest; our chair cushions and pads provide\n" +
                "softness where it counts. We have a wide variety of looks and\n" +
                "colors to suit your style, and many are machine-washable \n" +
                "(or have a cover that is) in case something spills.\n";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Has legs?: {Has_legs()}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
