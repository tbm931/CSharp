using System.Xml.Linq;

namespace Dal
{
    internal static class Config
    {


        private static readonly string filePath = @"..\xml\data-config.xml"; // נתיב הקובץ
        private static readonly XDocument doc = XDocument.Load(filePath); //private static XDocument doc = XDocument.Load(@"..\xml\data-config.xml");
        public static int NextProductId
        {
            get
            {
                XElement root = doc.Root!;
                XElement nextProductIdElement = root!.Element("NextProductId")!;
                if (nextProductIdElement != null)
                {
                    int currentValue = int.Parse(nextProductIdElement.Value);
                    nextProductIdElement.Value = (currentValue + 1).ToString(); // העלאת הערך ב-1
                }

                doc.Save(filePath);
                return int.Parse(nextProductIdElement!.Value);
            }
        }

        public static int NextSaleId
        {
            get
            {
                XElement root = doc.Root!;
                XElement SaleLast = root!.Element("NextSaleId")!;
                if (SaleLast != null)
                {
                    int currentValue = int.Parse(SaleLast.Value);
                    SaleLast.Value = (currentValue + 1).ToString();
                }

                doc.Save(filePath);
                return int.Parse(SaleLast!.Value);
            }
        }
    }
}
