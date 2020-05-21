using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Extractor
    {
   
        public static List<Chair> Dinning_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Dining_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> Cafe_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Cafe_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12],
                    values[13]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> Pads_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Pads_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> Childrens_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Childrens_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> High_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new High_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12],
                    values[13],
                    values[14]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> Desk_chairs_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Desk_chair(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12]
                    ));
                }
            }
            return chairs;
        }

        public static List<Chair> Stools_and_brenches_template(string file)
        {
            List<Chair> chairs = new List<Chair>();
            using (StreamReader sr = new StreamReader(file))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    string[] values = s.Split(';');

                    chairs.Add(new Stools_and_benches(
                    values[0],
                    Convert.ToInt32(values[1]),
                    Convert.ToInt32(values[2]),
                    values[3],
                    Convert.ToDouble(values[4], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[5], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[6], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[7], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[8], System.Globalization.CultureInfo.InvariantCulture),
                    Convert.ToDouble(values[9], System.Globalization.CultureInfo.InvariantCulture),
                    values[10],
                    values[11],
                    values[12]
                    ));
                }
            }
            return chairs;
        }
    }
}
