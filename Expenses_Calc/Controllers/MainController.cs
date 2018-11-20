using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Expenses_Calc.Controllers
{
    public class MainController : ApiController
    {
        Bussiness Bl = new Bussiness();
        [HttpGet]
        [Route("api/getexpenses")]
        public List<ExpensesCalc> GetExpenses()
        {
            return Bl.BGetExpenses();
        }
        [HttpPost]
        public void InsertExpenses(ExpensesCalc expensesCalc)
        {
            Bl.BInsertExpenses(expensesCalc);
        }
    }
}
