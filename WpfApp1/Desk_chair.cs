using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Desk_chair : Chair
    {
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }
        public string Height_management_level { get; set; }

        public Desk_chair(
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
                     string materials = "Kind of plastic",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg",
                     string height_management_level = "height-adjustability: medium")
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
            Height_management_level = height_management_level;
        }

        protected override string Has_legs()
        {
            return "model with rolling legs";
        }

        protected override string Model_description()
        {
            return "Comfortable chairs mean more time concentrating on the job\n" +
                "in hand rather than the pain in your back. Our swivel chairs\n" +
                "and other office chairs come with features like height-adjustable\n" +
                "seats, tilt functions and built-in lumbar support that your body\n" +
                "will love. And the different styles mean they fit in wherever you want.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Has legs?: {Has_legs()} || {Height_management_level}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
