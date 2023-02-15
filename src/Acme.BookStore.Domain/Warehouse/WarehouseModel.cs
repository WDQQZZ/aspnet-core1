using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Warehouse
{
    public class WarehouseModel : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 加工空托盘A0
        /// </summary>
        public int trayAZero { get; set; }
        /// <summary>
        /// 加工毛胚托盘A1
        /// </summary>
        public int trayHairGermAOne { get; set; }
        /// <summary>
        /// 加工成品托盘A1
        /// </summary>
        public int traySucceedATwo { get; set; }
        /// <summary>
        /// 检测完成托盘A3
        /// </summary>
        public int trayDetectionOkAThree { get; set; }
        /// <summary>
        /// 轴承压装毛胚托盘B1
        /// </summary>
        public int trayBearingBOne { get; set; }
        /// <summary>
        /// 轴承压装成品托盘B2
        /// </summary>
        public int trayBearingBTwo { get; set; }
        /// <summary>
        /// 轴承压装完成托盘B0
        /// </summary>
        public int trayBearingBZero { get; set; }
        /// <summary>
        /// 拧螺钉空托盘C0
        /// </summary>
        public int trayScrewCZero { get; set; }
        /// <summary>
        /// 拧螺钉打毛胚托盘C1
        /// </summary>
        public int trayScrewCOne { get; set; }
        /// <summary>
        /// 拧螺钉完成托盘C
        /// </summary>
        public int trayScrewBearing { get; set; }
        /// <summary>
        /// 轴承托盘D
        /// </summary>
        public int trayBearingDOne  { get; set; }
        /// <summary>
        /// 螺钉托盘E
        /// </summary>
        public int trayBoltEOne { get; set; }
        /// <summary>
        /// 库位无托盘
        /// </summary>
        public int WarehouseNoTray { get; set; }
        public string warehouseId { get; set; }
    }
}
