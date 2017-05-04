using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen2017 {
    class SeasonalProduct : Product {
        public DateTime SeasonalStartDate {
            get { return seasonalStartDate; }
            set { seasonalStartDate = value; } }
        public DateTime SeasonalEndDate {
            get { return seasonalEndDate; }
            set { seasonalEndDate = value; } }

        private DateTime seasonalStartDate;
        private DateTime seasonalEndDate;

        public SeasonalProduct(int productID, string name, int price, bool active, bool canBeBoughtOnCredit, DateTime seasonalStartDate, DateTime seasonalEndDate) 
            : base(productID, name, price, active, canBeBoughtOnCredit) {
            this.seasonalStartDate = seasonalStartDate;
            this.seasonalEndDate = seasonalEndDate;
        }
    }
}
