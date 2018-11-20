using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public List<ExpensesCalc> GetExpenses()
        {
            List<ExpensesCalc> list = null;
            using (ExpensesCalcEntities Ec = new ExpensesCalcEntities())
            {
                list =Ec.ExpensesCalcs.ToList();
            }
            return list;
        }
        public void InsertExpenses(ExpensesCalc expensesCalc)
        {
            using (ExpensesCalcEntities Ec = new ExpensesCalcEntities())
            {
                Ec.ExpensesCalcs.Add(expensesCalc);
                Ec.SaveChanges();
            }
        }
    }
}
