using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Order
{
    public class CUOrderDto
    {
        /// <summary>
        /// 订单类型
        /// </summary>
        [Required]
        [StringLength(128)]
        public string orderType { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime createOrderTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 完成数量
        /// </summary>
        [Required]
        public int accomplishNumber { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool isAccomplish { get; set; }

        public string orderNumber { get; set; }
    }
}
