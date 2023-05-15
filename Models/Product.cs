using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW.Lesson1.Models
{
    public class Product
    {
        public Product(string Name, string Description, string PathSmallImage, string PathLargeImage, int Count, float Price)
        {
            ProductId = new Guid();
            this.Name = Name;
            this.Description = Description;

            if (!string.IsNullOrWhiteSpace(PathSmallImage))
                this.PathSmallImage = PathSmallImage;

            if (!string.IsNullOrWhiteSpace(PathLargeImage))
                this.PathLargeImage = PathLargeImage;

            this.Count = Count;
            this.Price = Price;
        }

        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PathSmallImage { get; set; } = "default-image_450.png";
        public string PathLargeImage { get; set; } = "default-image_450.png";
        public int Count { get; set; }
        public float Price { get; set; }

    }
}
