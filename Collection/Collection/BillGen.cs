using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class BillGen
    {
        private int billNo;
        private int consumer_no;
        private double cost_per_unit, total_amt;
        private DateTime dueDate;

        public int Bill_No { get => billNo; set => billNo=value; }
        public int Consumer_No { get => consumer_no; set => consumer_no = value; }
        public double CostPerUnit { get => cost_per_unit; set => cost_per_unit = value; }
        public double TotalAmt { get => total_amt; set => total_amt = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }

    }
}
