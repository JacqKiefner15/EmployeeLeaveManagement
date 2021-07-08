using EmployeeLeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Contracts
{
   public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {

        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
