using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Order
{
    public class OrderModel : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNumber { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime createOrderTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 订单类型
        /// </summary>
        public string orderType { get; set; }
        /// <summary>
        /// 完成数量
        /// </summary>
        public int accomplishNumber { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public string isAccomplish { get; set; }
    }
}
