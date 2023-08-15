using De2.DomainClass;
using De2.Repositories;
using HaiNH_PH35304_De2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_PH35304_De2.Services
{
    internal class NXBService
    {
        NXBRepositories NXBRepositories;
        public NXBService()
        {
            NXBRepositories = new();
        }
        public List<Nxb> GetAll()
        {
            return NXBRepositories.GetAll();
        }
    }
}
