﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_MySql_Demo;

[Table("table_persons")]
public class Person
{
    [Column("person_id")]
    public int Id { get; set; }
    
    [Column("first_name")]
    [Required]
    public string? FirstName { get; set; }
    
    [Column("last_name")]
    [Required]
    public string? LastName { get; set; }
    
    [Column("age")]
    [Required]
    public int Age { get; set; }
}