﻿using System;
using System.Collections.Generic;

namespace ExpAnalyzer.Models
{
    internal class ClassHallData
    {
        /// <summary>
        /// ホール名
        /// </summary>
        public string HallName { get; set; }
        /// <summary>
        /// 機種データリスト
        /// </summary>
        public List<ClassModelData> ModelDataList { get; set; }
    }
}
