using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDHY.DW.Client
{
    public class LocMesModel
    {
        public string LocTitle { set; get; }

        public string DisplayName { set; get; }

        public string LocUtc { set; get; }

        public string LocTime { set; get; }
        /// <summary>
        /// 星下点
        /// </summary>
        public string SatLatLon { set; get; }
        /// <summary>
        /// 定位结果1
        /// </summary>
        public string LocResault1 { set; get; }
        /// <summary>
        /// 定位结果2
        /// </summary>
        public string LocResault2 { set; get; }
    }
}
