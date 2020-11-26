using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    /// <summary>
    /// 发送报文类型
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PackageTypeAttribute : Attribute
    {
        /// <summary>
        /// 发关报文实体类属性特性类
        /// </summary>
        /// <param name="SN">属性的序号，从1开始</param>
        /// <param name="Length">属性转成字符串后长度</param>
        public PackageTypeAttribute(uint OperationType, uint DataFormaterType, uint MinLength)
        {
            this.OperationType = OperationType;
            this.DataFormaterType = DataFormaterType;
            this.MinLength = MinLength;
        }
        /// <summary>
        /// 业务请求类型
        /// </summary>
        public uint OperationType
        { get; private set; }
        /// <summary>
        /// 数据解析格式类型
        /// </summary>
        public uint DataFormaterType
        { get; private set; }
        /// <summary>
        /// 数据串最小长度
        /// </summary>
        public uint MinLength
        { get; private set; }
    }

    /// <summary>
    /// 报文中属性的顺序SN和长度Length
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PackageAttribute : Attribute
    {
        /// <summary>
        /// 序号，从1开始
        /// </summary>
        public int SN
        { get; private set; }
        /// <summary>
        /// 转成字符串后的长度
        /// </summary>
        public int Length
        { get; private set; }
        /// <summary>
        /// 发关报文实体类属性特性类
        /// </summary>
        /// <param name="SN">属性的序号，从1开始</param>
        /// <param name="Length">属性转成字符串后长度</param>
        public PackageAttribute(int SN, int Length)
        {
            this.SN = SN;
            this.Length = Length;
        }
        /// <summary>
        /// 是否是时间类型,因为时间类型是左对齐，右补空格
        /// </summary>
        public bool IsDateTime
        { get; set; }
    }

    /// <summary>
    /// 取枚举的值还是
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class EnumValeuNumberAttribute : Attribute
    {
        /// <summary>
        /// 是否把枚举类型属性的的值数转成Char类型
        /// </summary>
        public bool IsChar
        { get; set; }
    }
}
