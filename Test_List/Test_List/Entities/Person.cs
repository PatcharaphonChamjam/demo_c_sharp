﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Test_List.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Picture { get; set; }

        public List<MoviesActors> MoviesActors { get; set; }
    }
}