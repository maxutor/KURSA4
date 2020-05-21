using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Childrens_chair : Chair
    {
        public override string ImagePath { get; set; }
        public override string Materials { get; set; }
        protected string Sertificate { get; set; }

        public Childrens_chair(
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
                     string sertificate = "Has baby-safe certificate")
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
        }

        protected override string Has_legs()
        {
            return "model with very stable legs";
        }

        protected override string Model_description()
        {
            return "Children's chairs are sized for comfort. Kids want chairs their own size,\n" +
                "not adult-size. We have different styles and types, options for indoors and out.\n" +
                "Easy-clean, durable and lightweight, so they're easy to move.";
                
        }

        public override string RenderResponse()
        {
            return $"{Model_description()}\n" +
                $"Has legs?: {Has_legs()} || {Sertificate}\n" +
                $"Materials: {Materials}\n" +
                $"{base.RenderResponse()}";
        }
    }
}
