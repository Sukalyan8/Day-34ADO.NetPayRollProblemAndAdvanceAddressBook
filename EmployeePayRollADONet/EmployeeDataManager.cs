using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRollADONet
{
    public class EmployeeDataManager
    {
        internal int c;

        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public DateTime startDate { get; set; }
        public char Gender { get; set; }
        public Int64 EmployeePhoneNumber { get; set; }
        public string EmployeeDepartment { get; set; }
        public string Address { get; set; }
        public double Deduction { get; set; }
        public double IncomeTax { get; set; }
        public double TaxablePay { get; set; }
        public double NetPay { get; set; }
        public int CompanyID { get; internal set; }
        public string CompanyName { get; internal set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int BasicPay { get; set; }
    }
}