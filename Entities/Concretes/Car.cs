﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Car:IEntity
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public string ModelYear { get; set; }

        public string Name { get; set; }

        public int DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
