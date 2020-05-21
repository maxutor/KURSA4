using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Stools_and_benches : Chair
    {
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }
        public string Storage_bench { get; set; }

        public Stools_and_benches(
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
                     string materials = "wood",
                     string imagePath = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Gull_portrait_ca_usa.jpg",
                     string storage = "without storage")
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
            ImagePath = imagePath;
            Storage_bench = storage;
            Materials = materials;
        }

        protected override string Has_legs()
        {
            return "model with four legs";
        }

        protected override string Model_description()
        {
            return "With a little help from our stools and benches,\n" +
                "your guests will never have to fight for a place again.\n" +
                "Benches seat more people and ours are designed to match\n" +
                "our tables in size and style. And you can stack most of\n" +
                "our stools away or just push them under the table when\n" +
                "it’s time to show off your latest dance moves.";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Has legs?: {Has_legs()} || {Storage_bench}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
