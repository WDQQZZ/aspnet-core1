using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Order
{
    public class OrderDto: AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNumber { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime createOrderTime { get; set; }
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
        public bool isAccomplish { get; set; }
    }
}
