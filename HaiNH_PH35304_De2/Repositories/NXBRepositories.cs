using De2.Context;
using De2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_PH35304_De2.Repositories
{
    internal class NXBRepositories
    {
        FinalassFpolyNetJavaSm22Bl2Context dbContext;

        public NXBRepositories()
        {
            dbContext = new();
        }
        public List<Nxb> GetAll()
        {
            var lstNXB = dbContext.Nxbs.ToList();
            return lstNXB;
        }
    }
}
