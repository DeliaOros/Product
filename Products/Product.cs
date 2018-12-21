using System;

namespace Products
{
    public class Product
    {
        private string name;
        private float weight;
        private string producer;
        public enum Categories { Dairy = 1, Fruit, Beverages, Bread };
        private readonly Categories productCategory;
        private DateTime productionDate;
        private readonly DateTime expirationDate;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }


        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }


        public Categories ProductCategory
        {
            get { return productCategory; }
        }


        public DateTime ExpirationDate
        {
            get

            {
                if (expirationDate > DateTime.Now)
                {
                    return expirationDate;
                }
                else
                {
                    return DateTime.MinValue;
                }

            }

        }
        public Product(Categories category, int productionYear, int productionMonth, int productionDay, int productionHour, int productionSecond, int productionMilisecond)
        {
            this.productionDate = new DateTime(productionYear, productionMonth, productionDay, productionHour, productionSecond, productionMilisecond);
            this.productCategory = category;
            switch (productCategory)
            {
                case Categories.Beverages:
                    expirationDate = productionDate.AddYears(3);
                    break;
                case Categories.Bread:
                    expirationDate = productionDate.AddDays(4);
                    break;
                case Categories.Dairy:
                    expirationDate = productionDate.AddDays(7);
                    break;
                case Categories.Fruit:
                    expirationDate = productionDate.AddDays(2);
                    break;
                default:
                    expirationDate = productionDate.AddYears(-10);
                    break;
            }
            if (expirationDate < DateTime.Now)
            {
                Console.WriteLine("WARNING! The product expired at {0}, withdraw it from consumption and report event!", expirationDate.ToString());
            }
        }
        public override string ToString()
        {
            return string.Format("This product is {0} from {1} category and weights {2} kg. It expires at {3}."
                                , this.Name.ToString().ToUpper(), this.ProductCategory.ToString(),
                                this.Weight.ToString(), this.ExpirationDate.ToString());
        }

    }
}
