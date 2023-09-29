using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using CsvHelper;
using CsvHelper.Configuration;
using System.ComponentModel.DataAnnotations;


namespace sampleDotnetProject.Models;

public class Student {
    
    [Key]
    public int StudentId {get; set;}
    public string Gender {get; set;} = string.Empty;
    public int Marks {get; set;}
}