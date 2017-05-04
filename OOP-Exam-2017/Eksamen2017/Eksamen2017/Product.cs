﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017
{
    class Product {
        public int  ProductID { get { return productID; } }
        public string Name { get { return name; } }
        public int Price {
            get { return price; }
            set { price = value; } }
        public bool Active {
            get { return active; }
            set { active = value; } }
        public bool CanBeBoughtOnCredit {
            get { return canBeBoughtOnCredit; }
            set { canBeBoughtOnCredit = value; } }

        private int productID;
        private string name;
        private int price;
        private bool active;
        private bool canBeBoughtOnCredit;

        public Product(int productID, string name, int price, bool active, bool canBeBoughtOnCredit) {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.active = active;
            this.canBeBoughtOnCredit = canBeBoughtOnCredit;

        } 
    }

}
