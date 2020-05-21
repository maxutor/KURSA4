using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class High_chair : Childrens_chair
    {
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }
        public new string Sertificate { get; set; }
        public string Little_description { get; set; }
        public string Care_instructions { get; set; }

        public High_chair(
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
                     string sertificate = "Has safety certificate",
                     string little_description = "smth",
                     string care_instructions = "we`are lost instructions, sorrryyyy")
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
            Sertificate = sertificate;
            Little_description = little_description;
            Care_instructions = care_instructions;
        }

        protected override string Has_legs()
        {
            return Little_description;
        }

        protected override string Model_description()
        {
            return "Children's chairs are sized for comfort.\n" +
                "And these things will increase comfort many times more";
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Clarification: {Has_legs()} || {Sertificate}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}\n" +
                $"Care instructions:{Care_instructions}";
        }
    }
}
