﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("user_name")]
        public string Username { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("full_name")]
        public string Name { get; set; }
        [Column("refresh_token")]
        public string RefreshToken { get; set; }
        [Column("refresh_token_expiry_time")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
