﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.EntityLayer.Concrete
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public int CarCategoryID { get; set; }
        public CarCategory CarCategory { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public string ImageURL { get; set; }
        public string GearType { get; set; }
        public int km { get; set; }
        public byte PersonCount { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }
        public int CarStatusID { get; set; }
        //public int GearTypID { get; set; }
        //public GearTyp GearTyp { get; set; }
        //public int CarModelID { get; set; }
        //public CarModel CarModel { get; set; }
        //public int CarYearID { get; set; }
        //public CarYear CarYear { get; set; }
        public CarStatus CarStatus { get; set; }
        public List<Price> Prices { get; set; }
        public List<CarDetail> CarDetails { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
