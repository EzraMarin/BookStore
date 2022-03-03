using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface ICheckoutRepository
    {
        public IQueryable<Checkout> Checkouts { get; }

        public void saveCheckout(Checkout checkout);
    }
}
