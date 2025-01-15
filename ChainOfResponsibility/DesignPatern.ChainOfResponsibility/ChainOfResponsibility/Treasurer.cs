using DesignPatern.ChainOfResponsibility.DAL;
using DesignPatern.ChainOfResponsibility.Models;

namespace DesignPatern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Treaasurer: Ayse Cinar";
                customerProcess.Description = "Withdrawal process has been approved. The requested amount gave to customer";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Treaasurer: Ayse Cinar";
                customerProcess.Description = "Since the withdrawal amount exceeded the daily amount of the treaasurer, the transaction was forwarded to the Assistant Branch Manager.";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
