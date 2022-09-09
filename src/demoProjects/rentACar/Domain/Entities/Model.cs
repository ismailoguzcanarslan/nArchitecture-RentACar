using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model : Entity 
    {
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; }
        public int BrandId { get; set; }

        public Model()
        {

        }

        public Model(int id, string name, decimal dailyPrice, string imageUrl, int brandId):this()
        {
            Id = id;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
            BrandId = brandId;
        }
    }
}
