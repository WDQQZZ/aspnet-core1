using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.MESAGV
{
    public class SystemHomePageDto : AuditedEntityDto<Guid>
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
        public DateTime orderTime { get; set; }
        public string orderId { get; set; }
    }
}
