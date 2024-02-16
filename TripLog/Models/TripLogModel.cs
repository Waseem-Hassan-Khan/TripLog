using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripLog.Models
{
    public class TripLogModel
    {
            public int TripId { get; set; }
            public string Destination { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Accommodation { get; set; }
            public string AccommodationPhone { get; set; }
            public string AccommodationEmail { get; set; }
            public string ThingToDo1 { get; set; }
            public string ThingToDo2 { get; set; }
            public string ThingToDo3 { get; set; }
        }
    }


    /* 
     * 
     USE master;
    GO

    -- Create a new database
    CREATE DATABASE TripLog;
    GO

    -- Switch to the TripLog database
    USE TripLog;
    GO

    -- Create the TripLog table
    CREATE TABLE TripLogs
    (
        TripId INT PRIMARY KEY IDENTITY(1,1),
        Destinantion NVARCHAR(255),
        StartDate DATETIME,
        EndDate DATETIME,
        Accommodation NVARCHAR(255),
        AccommodationPhone NVARCHAR(20),
        AccommodationEmail NVARCHAR(255),
        ThingToDo1 NVARCHAR(255),
        ThingToDo2 NVARCHAR(255),
        ThingToDo3 NVARCHAR(255)
    );
    GO 
     *
     */
