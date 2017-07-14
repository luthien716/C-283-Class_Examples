using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLibrary;

namespace Example02_1_Library
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "黃亦捷",
                mobile = "0912345667",
                address = "台大"
            };
            Console.WriteLine(
                "學生姓名:{0}, 電話:{1}, 地址:{2}"
                , aStudent.name
                , aStudent.mobile
                , aStudent.address
            );
        }
    }
}