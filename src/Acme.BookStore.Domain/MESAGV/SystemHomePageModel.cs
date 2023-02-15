using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.MESAGV
{
    public class SystemHomePageModel: AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 订单数量
        /// </summary>
        public int OrderNum { get; set; }
        /// <summary>
        /// 上料类型
        /// </summary>
        public string FeedingType { get; set; }
        /// <summary>
        /// 料盘参数
        /// </summary>
        public decimal TrayParameter { get; set; }
        /// <summary>
        /// 下料类型
        /// </summary>
        public string BlankingType { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime orderTime { get; set; } = DateTime.Now;

        public string orderId { get; set; }
    }
}
