using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
