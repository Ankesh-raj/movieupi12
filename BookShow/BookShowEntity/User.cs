﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShowEntity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto generate Column.

        public int Id { get; set; }

       
        public string Name { get; set; }

       
        public string Email { get; set; }
       
        public string Password { get; set; }

        public string phone { get; set; }

       
        public string  Role { get; set; }


    }
}