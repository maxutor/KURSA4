using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ChairManager
    {
        public List<string> Filters { get; set; }
        public string category = "all_chairs";
        public string option = "None";
        public string Search_option_color { get; set; } = "None";
        public string Search_option_material { get; set; } = "None";

        public List<Chair> Get_filtered_sorted_chairs()
        {
            List<Chair> chairs = Get_all_chairs_by_category(category);
            chairs = Filter_chairs(chairs);
            chairs = Order_by(chairs);
            chairs = Search_by_color(chairs);
            chairs = Search_by_material(chairs);
            return chairs;
        }

        private List<Chair> Filter_chairs(List<Chair> chairs)
        {
            foreach(string filter in Filters)
            {
                switch (filter)
                {
                    case "less than 201":
                        chairs = chairs.Where(c => c.Price <= 200).ToList();
                        break;
                    case "more than 200":
                        chairs = chairs.Where(c => c.Price > 200).ToList();
                        break;
                    case "avaible":
                        chairs = chairs.Where(c => c.Is_avaible() == true).ToList();
                        break;
                }
            }
            return chairs;
        }

        private List<Chair> Order_by(List<Chair> chairs)
        {
            switch (option)
            {
                case "ASC":
                    chairs = chairs.OrderBy(c=>c.Price).ToList();
                    break;
                case "DESC":
                    chairs = chairs.OrderByDescending(c => c.Price).ToList();
                    break;
            }
            return chairs;
        }

        public List<Chair> Get_all_chairs_by_category(string category_name)
        {
           switch (category_name)
            {
                case "dinner_chairs":
                    return Extractor.Dinning_chairs_template("Dinning_chairs.csv");
                case "cafe_chairs":
                    return Extractor.Cafe_chairs_template("Cafe_chairs.csv");
                case "pads_chairs":
                    return Extractor.Pads_chairs_template("Pads_chairs.csv");
                case "children`s_chairs":
                    return Extractor.Childrens_chairs_template("Childrens_chairs.csv");
                case "high_chairs":
                    return Extractor.High_chairs_template("High_chairs.csv");
                case "desk_chairs":
                    return Extractor.Desk_chairs_template("Desk_chairs.csv");
                case "stools_and_brenches":
                    return Extractor.Stools_and_brenches_template("Stools_and_benches.csv");
                case "all_chairs":
                    List<Chair> all_chairs = new List<Chair>();
                    all_chairs.AddRange(Extractor.Dinning_chairs_template("Dinning_chairs.csv"));
                    all_chairs.AddRange(Extractor.Pads_chairs_template("Pads_chairs.csv"));
                    all_chairs.AddRange(Extractor.Childrens_chairs_template("Childrens_chairs.csv"));
                    all_chairs.AddRange(Extractor.High_chairs_template("High_chairs.csv"));
                    all_chairs.AddRange(Extractor.Desk_chairs_template("Desk_chairs.csv"));
                    all_chairs.AddRange(Extractor.Stools_and_brenches_template("Stools_and_benches.csv"));
                    all_chairs.AddRange(Extractor.Cafe_chairs_template("Cafe_chairs.csv"));
                    return all_chairs;
            }
            return null;
        }

        private List<Chair> Search_by_color(List<Chair> chairs)
        {
            if (Search_option_color != "None" && Search_option_color != "")
            {
                chairs = chairs.Where(c => c.Color.Contains(Search_option_color)).ToList();
                return chairs;
            }
            else
            {
                return chairs;
            }
        }

        private List<Chair> Search_by_material(List<Chair> chairs)
        {
            if (Search_option_material != "None" && Search_option_material != "")
            {
                chairs = chairs.Where(c => c.Materials.Contains(Search_option_material)).ToList();
                return chairs;
            }
            else
            {
                return chairs;
            }
        }
    }
}   
