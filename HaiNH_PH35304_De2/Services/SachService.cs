using De2.DomainClass;
using De2.Repositories;

namespace De2.Services
{
    internal class SachService
    {
        SachRepository sachRepository;

        public SachService()
        {
            sachRepository = new();
        }

        public List<Sach> GetAll()
        {
            return sachRepository.GetAll();
        }

        public List<Sach> FindByName(string name)
        {
            return sachRepository.FindByName(name);
        }
        public Sach Add(Sach sach)
        {
            return sachRepository.Add(sach);
        }
        public void Update(Sach sach)
        {
            sachRepository.Update(sach);
        }
        public void Delete(Sach sach)
        {
            sachRepository.Delete(sach);
        }

        public bool IsMaSachExists(string maSach)
        {
            List<Sach> lstSach = GetAll();
            return lstSach.Any(sach => sach.Ma == maSach);
        }
    }
}
