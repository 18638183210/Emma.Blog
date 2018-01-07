﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Emma.Blog.Data.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public string NickName { get; set; }

        public string Phone { get; set; }

        public string HeadImg { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}