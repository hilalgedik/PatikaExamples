using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmProject.Entity;

namespace AtmProject.Business
{
    public class ProcessManager
    {
       
        
        Process _process;

        public ProcessManager(Process process)
        {
            _process = process;
        }

        public bool SelectProcess(Process _process)
        {
            string filePath;
            filePath = LogManager.CreateTxt();
            switch (_process.ProcessName)
            {
                case "WithdrawMoney":
                    LogManager.WriteFile(_process, filePath);
                    return WithdrawMoney();
                    break;

                case "Deposit":
                    LogManager.WriteFile(_process, filePath);
                    return Deposit();
                    break;
default:
    return true;
            }
            
        }
        public bool WithdrawMoney()
        {
            Console.WriteLine("Para çekme işleminiz gerçekleşmiştir.");
            return true;
        }

        public bool Deposit()
        {
            Console.WriteLine("Para yatırma işleminiz gerçekleşmiştir.");
            return true;
        }


    }
}
