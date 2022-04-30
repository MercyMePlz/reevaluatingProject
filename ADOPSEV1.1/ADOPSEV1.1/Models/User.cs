﻿using ADOPSEV1._1.Data;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace ADOPSEV1._1.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "First Name: ")]
        public string first_name { get; set; }

        [Required]
        [Display(Name = "Last Name: ")]
        public string last_name { get; set; }

        [EmailAddress]
        [StringLength(150)]
        [Display(Name = "Email Address: ")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(150, MinimumLength = 6)]
        [Display(Name = "Password: ")]
        public string password { get; set; }
       // public string PasswordSalt { get; set; }
        [Required]
        public string username { get; set; }

        public int role { get; set; }

       // public int SaveDetails()
        //{
            //string connectionString = configuration.GetConnectionString("Default");
            //SqlConnection con = new(connectionString);
            //string query = "INSERT INTO users(Name, Age, City) values ('" + first_name + "','" + last_name + "','" + email + "','" + password + "','" + username + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //return i;
            
        //}

    }
}
