using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Facility
{
    public class FacilityModel:AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 动作类型
        /// </summary>
        public string typeOfAction { get; set; }
        /// <summary>
        /// 库位号
        /// </summary>
        public int warehouseNumber { get; set; }
        /// <summary>
        /// 托盘类型
        /// </summary>
        public string trayType   { get; set; }
        /// <summary>
        /// 起点地图点
        /// </summary>
        public string originMap  { get; set; }
        /// <summary>
        /// 终止地图点
        /// </summary>
        public string terminationMap    { get; set; }
    }
}
