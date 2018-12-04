using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DotNETCore.Lab.Lab1_TheFirstUnitTest
{
    public class Eliminator
    {
        /// <summary>
        /// 消除字串空白
        /// </summary>
        /// <param name="obj">物件</param>
        public T EliminateSpace<T>(T obj)
        {
            if (obj != null)
            {
                PropertyInfo[] properites = obj.GetType().GetProperties();
                foreach (var property in properites)
                {
                    if (property.PropertyType == typeof(string))
                    {
                        if (property.GetValue(obj) != null)
                        {
                            var value = property.GetValue(obj).ToString();
                            property.SetValue(obj, value.Trim());
                        }
                    }
                }
                return obj;
            }
            else
            {
                throw new ArgumentNullException("不可傳入Null物件");
            }
        }
    }
}
