using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(IHeadingService heading);
        IHeadingService GetByID(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
