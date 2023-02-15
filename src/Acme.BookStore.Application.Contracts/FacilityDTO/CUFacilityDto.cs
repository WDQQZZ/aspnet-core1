using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.FacilityDTO
{
    public class CUFacilityDto
    {
        /// <summary>
        /// 动作类型
        /// </summary>
         [Required]
        [StringLength(128)]
        public string typeOfAction { get; set; }
        /// <summary>
        /// 库位号
        /// </summary>
        public int warehouseNumber { get; set; }
        /// <summary>
        /// 托盘类型
        /// </summary>
        [Required]
        [StringLength(128)]
        public string trayType { get; set; }
        /// <summary>
        /// 起点地图点
        /// </summary>
        [Required]
        [StringLength(128)]
        public string originMap { get; set; }
        /// <summary>
        /// 终止地图点
        /// </summary>
        [Required]
        [StringLength(128)]
        public string terminationMap { get; set; }
    }
}
