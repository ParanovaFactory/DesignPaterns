using DesignPatern.ChainOfResponsibility.DAL;
using DesignPatern.ChainOfResponsibility.Models;

namespace DesignPatern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Manager Assistant: Selvi Çakır";
                customerProcess.Description = "Withdrawal process has been approved. The requested amount gave to customer";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Manager Assistant: Selvi Çakır";
                customerProcess.Description = "Since the withdrawal amount exceeded the daily amount of the Manager Assistant, the transaction was forwarded to the Branch Manager.";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
