using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    /// <summary>
    /// 医师信息查询
    /// </summary>
    [PackageType(1009, 504, 85)]
    public class DoctorQuery : Entity
    {
        /// <summary>
        /// 医师编码
        /// </summary>
        [Package(1, 8)]
        public virtual String DoctorCode
        {
            get; set;
        }
        /// <summary>
        /// 医师姓名
        /// </summary>
        [Package(2, 20)]
        public virtual String DoctorName
        { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Package(3, 18)]
        public virtual string PersonID
        { get; set; }

        ///编号为0002的医院， 下属有编号为0113的定点， 在总院注册登记的医师可以在这样的2家医院出诊， 则“可出诊医院编号”为00020113，若长度不足20位则前补空格。
        /// <summary>
        /// 可出诊医院编号
        /// </summary>
        [Package(4, 20)]
        public virtual string CanVisitHospitalCode
        { get; set; }

        /// <summary>
        /// 终止日期
        /// </summary>
        [Package(5, 16, IsDateTime = true)]
        public virtual string TerminationTime
        { get; set; }

        /// <summary>
        /// 有效标志
        /// </summary>
        [Package(6, 1)]
        public virtual DLYBAvailableMarker DLYBAvailableMarker
        { get; set; }
    }

    /// <summary>
    /// 有效标志
    /// </summary>
    [EnumValeuNumber]
    public enum DLYBAvailableMarker
    {
        /// <summary>
        /// 无效
        /// </summary>
        nullity = 0,
        /// <summary>
        /// 有效
        /// </summary>
        Valid = 1
    }

    /// <summary>
    /// 实时验卡（读卡、验卡）
    /// </summary>
    [PackageType(1001, 101, 126)]
    public class QueryCardEntity : Entity
    {
        /// <summary>
        /// 个人编号
        /// </summary>
        [Package(1, 8)]
        public virtual string PersonNumber
        { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Package(2, 20)]
        public virtual string Name
        { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Package(3, 18)]
        public virtual string PersonID
        { get; set; }

        /// <summary>
        /// IC卡号
        /// </summary>
        [Package(4, 9)]
        public virtual string ICCardNumber
        { get; set; }

        long therapyNumber;
        /// <summary>
        /// 治疗序号
        /// </summary>
        [Package(5, 4)]
        public virtual long TherapyNumber
        {
            get
            {
                return therapyNumber;
            }
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    therapyNumber = value;
                }
                else
                {
                    throw new Exception("治疗号在0-9999之间");
                }

            }
        }

        /// <summary>
        /// 职工就医类别
        /// </summary>
        [Package(6, 1)]
        public virtual string TherapyCategory
        { get; set; }

        /// <summary>
        /// 基本个人帐户余额
        /// </summary>
        [Package(7, 10)]
        public virtual decimal BasePersonBalance
        { get; set; }

        /// <summary>
        /// 补助个人帐户余额
        /// </summary>
        [Package(8, 10)]
        public virtual decimal SubsidyPersonBalance
        { get; set; }

        /// <summary>
        /// 统筹累计
        /// </summary>
        [Package(9, 10)]
        public virtual decimal PlannerTotal
        { get; set; }

        /// <summary>
        /// 门诊慢病统筹累计///新
        /// </summary>
        [Package(10, 10)]
        public virtual decimal MZSlowDisease
        { get; set; }

        /// <summary>
        /// 月缴费基数
        /// </summary>
        [Package(11, 10)]
        public virtual decimal BaseFeeByMonth
        { get; set; }

        /// <summary>
        /// 帐户状态
        /// </summary>
        [Package(12, 1)]
        public virtual string AccoutState
        { get; set; }

        /// <summary>
        /// 参保类别1
        /// </summary>
        [Package(13, 1)]
        public virtual string InsuranceCategory1
        { get; set; }

        /// <summary>
        /// 参保类别2
        /// </summary>
        [Package(14, 1)]
        public virtual string InsuranceCategory2
        { get; set; }

        /// <summary>
        /// 参保类别3
        /// </summary>
        [Package(15, 1)]
        public virtual string InsuranceCategory3
        { get; set; }

        /// <summary>
        /// 参保类别4
        /// </summary>
        [Package(16, 1)]
        public virtual string InsuranceCategory4
        { get; set; }

        /// <summary>
        /// 参保类别5
        /// </summary>
        [Package(17, 1)]
        public virtual string InsuranceCategory5
        { get; set; }

        /// <summary>
        /// 住院次数累计////新
        /// </summary>
        [Package(18, 4)]
        public virtual int ZYAddNumber
        { get; set; }

        /// <summary>
        /// 家床次数累计////新
        /// </summary>
        [Package(19, 4)]
        public virtual int AddBedNumber
        { get; set; }
    }
}
