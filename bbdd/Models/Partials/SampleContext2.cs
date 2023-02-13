using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.SqlServer;

namespace bbdd.Models
{
    public partial class SampleContext2
    {
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
}
