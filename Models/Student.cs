﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternInMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Age { get; set; }

        public string Title { get; set; }
    }
}