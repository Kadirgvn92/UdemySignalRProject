using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete;
public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonalDal;

    public TestimonialManager(ITestimonialDal testimonalDal)
    {
        _testimonalDal = testimonalDal;
    }

    public void TAdd(Testimonial entity)
    {
        _testimonalDal.Add(entity);
    }

    public void TDelete(Testimonial entity)
    {
        _testimonalDal.Delete(entity);
    }

    public Testimonial TGetByID(int id)
    {
        return _testimonalDal.GetByID(id);
    }

    public List<Testimonial> TGetListAll()
    {
        return _testimonalDal.GetListAll();
    }

    public void TUpdate(Testimonial entity)
    {
        _testimonalDal.Update(entity);
    }
}
