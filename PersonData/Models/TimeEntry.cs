﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class TimeEntry
    {
        public int TimeEntryID { get; }
        public int EmployeeID { get; }
        public DateTime ClockIn { get; }
        public DateTime ClockOut { get; }
        public TimeEntry(int timeentryID, int employeeID, DateTime clockin, DateTime clockout)
        {
            TimeEntryID = timeentryID;
            EmployeeID = employeeID;
            ClockIn = clockin;
            ClockOut = clockout;
        }
    }
}
