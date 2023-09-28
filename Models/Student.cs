using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using CsvHelper;
using CsvHelper.Configuration;


namespace sampleDotnetProject.Models;

public class Student {

    public int Student_ID {get; set;}
    public string Gender {get; set;} = string.Empty;
    public int Marks {get; set;}
}