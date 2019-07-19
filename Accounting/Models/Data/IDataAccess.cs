using Accounting.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Models.Data
{
    interface IDataAccess
    {
        IEnumerable<MoneyViewModel> GetList();
    }
}
