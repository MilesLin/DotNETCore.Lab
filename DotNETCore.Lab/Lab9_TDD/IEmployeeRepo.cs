using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCore.Lab.Lab9_TDD
{
    public interface IEmployeeRepo
    {
        EmployeeInfo GetEmployeeInfo(int id);
    }

    public class EmployeeInfo
    {
        /// <summary>
        ///員工編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部門
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// 職等
        /// </summary>
        public Position Position { get; set; }
    }

    public enum Department
    {
        管理部,
        業務部
    }

    public enum Position
    {
        職等一,
        職等二
    }
}
