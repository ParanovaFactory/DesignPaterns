using DesignPatern.ChainOfResponsibility.DAL;
using DesignPatern.ChainOfResponsibility.Models;

namespace DesignPatern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Area Director : Derya Durmaz";
                customerProcess.Description = "Withdrawal process has been approved. The requested amount gave to customer";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Area Director : Derya Durmaz";
                customerProcess.Description = "Since the withdrawal amount exceeded the daily amount of the Area Director, the transaction was rejected by the Area Director. The maximum daily withdrawal amount of money the customer can withdraw is 400,000 TL, and for more, he/she must come to the branch on different days.";
                customerProcess.Date = System.DateTime.Now;
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
