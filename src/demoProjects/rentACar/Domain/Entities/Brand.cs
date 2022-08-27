using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        public Brand()
        {

        }

        //"this()" means also run parameterless constructor.
        //we use parameter when we've a common things to run. 
        public Brand(int id,string name):this()
        {
            Name = name;
            Id = id;
        }
    }
}
