using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data; 

namespace Business
{
    public class BInvoice
    {
        public List<invoices> GetByDate(DateTime? date)
        {
            DInvoice data = new DInvoice();
            var invoices = data.Get();
            var result = invoices.Where(x => x.date == date).ToList();
            return result;
        }

    }
}
