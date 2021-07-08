using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Models
{
    public class LeaveHistoryVM
    {

        public int Id { get; set; }


        public EmployeeVM RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [ForeignKey("LeaveTypeId")]

        public LeaveTypeVM LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime DataRequested { get; set; }

        public DateTime DateActioned { get; set; }

        public bool? Approved { get; set; }
        [ForeignKey("ApprovedById")]

        public EmployeeVM ApprovedBy { get; set; }

        public string ApprovedById { get; set; }
    }
}
