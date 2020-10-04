using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Gujian3Helper
{
    public class RoleProperty
    {
        private uint _ATK = 1;
        /// <summary>
        /// 攻击力
        /// </summary>
        [DisplayName("攻击力")]
        [Description("攻击力")]
        public uint ATK
        {
            get => _ATK;
            set
            {
                if (value <= 0)
                    _ATK = 1;
                else if (value > 100000)
                    _ATK = 100000;
                else
                    _ATK = value;
            }        
        }
        private uint _HP = 1;
        /// <summary>
        /// 生命值
        /// </summary>
        [DisplayName("生命值")]
        [Description("生命值")]
        public uint HP 
        {
            get => _HP;
            set
            {
                if (value <= 0)
                    _HP = 1;
                else if (value > 100000)
                    _HP = 100000;
                else
                    _HP = value;
            }
        }
        private uint _Defense = 1;
        /// <summary>
        /// 防御
        /// </summary>
        [DisplayName("防御")]
        [Description("防御")]
        public uint Defense
        {
            get => _Defense;
            set
            {
                if (value <= 0)
                    _Defense = 1;
                else if (value > 100000)
                    _Defense = 100000;
                else
                    _Defense = value;
            }
        }

        private double _MP = 0;
        /// <summary>
        /// 法力值
        /// </summary>
        [DisplayName("法力值")]
        [Description("法力值")]
        public double MP
        {
            get => _MP;
            set
            {
                if (value <= 0)
                    _MP = 0;
                else if (value > 3000)
                    _MP = 3000;
                else
                    _MP = value;
            }
        }
        private uint _CriticalSTK = 0;
        /// <summary>
        /// 暴击伤害
        /// </summary>
        [DisplayName("暴击伤害")]
        [Description("暴击伤害")]
        public uint CriticalSTK
        {
            get => _CriticalSTK;
            set
            {
                if (value <= 0)
                    _CriticalSTK = 0;
                else if (value > 30000)
                    _CriticalSTK = 30000;
                else
                    _CriticalSTK = value;
            }
        }
        private uint _CriticalSTKOdds = 0;
        /// <summary>
        /// 暴击率
        /// </summary>
        [DisplayName("暴击率")]
        [Description("暴击率")]
        public uint CriticalSTKOdds
        {
            get => _CriticalSTKOdds;
            set
            {
                if (value <= 0)
                    _CriticalSTKOdds = 0;
                else if (value > 100)
                    _CriticalSTKOdds = 100;
                else
                    _CriticalSTKOdds = value;
            }
        }
        private double _PhysicalValues = 0;
        /// <summary>
        /// 体力值
        /// </summary>
        [DisplayName("体力值")]
        [Description("体力值")]
        public double PhysicalValues
        {
            get => _PhysicalValues;
            set
            {
                if (value <= 0)
                    _PhysicalValues = 0;
                else if (value > 100)
                    _PhysicalValues = 100;
                else
                    _PhysicalValues = value;
            }
        }
        private double _PhysicalValuesRecovery = 0;
        /// <summary>
        /// 体力回复速度
        /// </summary>
        [DisplayName("体力回复速度")]
        [Description("体力回复速度")]
        public double PhysicalValuesRecovery
        {
            get => _PhysicalValuesRecovery;
            set
            {
                if (value <= 0)
                    _PhysicalValuesRecovery = 0;
                else if (value > 100)
                    _PhysicalValuesRecovery = 100;
                else
                    _PhysicalValuesRecovery = value;
            }
        }

    }
}
