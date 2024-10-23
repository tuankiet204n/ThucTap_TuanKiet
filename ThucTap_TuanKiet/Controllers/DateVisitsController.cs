using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucTap_TuanKiet.Model;
using ThucTap_TuanKiet.Services;

namespace ThucTap_TuanKiet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateVisitsController : ControllerBase
    {
        private readonly IDateVisit dateVisit;
        public DateVisitsController(IDateVisit dateVisit)
        {
            this.dateVisit = dateVisit;
        }
        [HttpGet("{idVisitSchedule}")]
        public ActionResult GetByIdViSc(int idVisitSchedule)
        {
            return Ok(dateVisit.dateVisitByIdViSc(idVisitSchedule));
        }
        [HttpPost]
        public ActionResult Add(DateTime date, int idVisitSchedule)
        {
            var daVi = dateVisit.Add(date, idVisitSchedule);
            if (daVi == null)
                return BadRequest();
            return CreatedAtAction("Add", daVi);
        }
    }
}