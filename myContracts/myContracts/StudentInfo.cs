﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myContracts
{
    /// <summary>
    /// 学生信息实体类
    /// </summary>
    class StudentInfo
    {
        public int StudentId { set; get; }
        public string Name { set; get; }
        public string Sex { set; get; }
        public int Age { set; get; }
        public DateTime BirthDate { set; get; }
        public string Phone { set; get; }
        public string HomeAddress { set; get; }
        public string Email { set; get; }
        public string Profession { set; get; }
    }
}
