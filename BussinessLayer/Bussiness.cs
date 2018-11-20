using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class Bussiness
    {
        DataAccess Da = new DataAccess();
        public List<ExpensesCalc> BGetExpenses()
        {
            return Da.GetExpenses();
        }
        public void BInsertExpenses(ExpensesCalc expensesCalc)
        {
            Da.InsertExpenses(expensesCalc);
        }

    }
}
