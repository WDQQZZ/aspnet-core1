using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.MESAGV
{
    public class CUSystemHomePageDto
    {
        /// <summary>
        /// 订单类型
        /// </summary>         
        [Required]
        [StringLength(128)]
        public string OrderType { get; set; }
        /// <summary>
        /// 订单数量
        /// </summary>
        [Required]
        public int OrderNum { get; set; }
        /// <summary>
        /// 上料类型
        /// </summary>
        [Required]
        public string FeedingType { get; set; }
        /// <summary>
        /// 料盘参数
        /// </summary>
        [Required]
        public decimal TrayParameter { get; set; }
        /// <summary>
        /// 下料类型
        /// </summary>
        [Required]
        public string BlankingType { get; set; }
    }
}
