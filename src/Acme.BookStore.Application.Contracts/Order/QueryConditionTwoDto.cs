using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Order
{
    public class QueryConditionTwoDto
    {
        public string orderNumber { get; set; }
        public string createOrderTime { get; set; }
        public DateTime createOrderTimedate { get; set; }
        public string orderType { get; set; }
        public int orderNum { get; set; }
        public int accomplishNumber { get; set; }
        public string orderType1 { get; set; }
        public string feedingType { get; set; }
        public string blankingType { get; set; }
        public decimal trayParameter { get; set; }
    }
}
