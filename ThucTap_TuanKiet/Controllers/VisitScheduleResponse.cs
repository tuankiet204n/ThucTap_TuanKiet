using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;
using Microsoft.EntityFrameworkCore;
using ThucTap_TuanKiet.Services;

namespace ThucTap_TuanKiet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitSchedulesController : ControllerBase
    {
        private readonly IVisitSchedule visitSchedule;
        public VisitSchedulesController(IVisitSchedule visitSchedule)
        {
            this.visitSchedule = visitSchedule;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(visitSchedule.VisitScheduleList());
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(visitSchedule.GetVisitSchedule(id));
        }
        [HttpPost]
        public ActionResult Add(string session, string purpose, int idDistributor, int idCreator)
        {
            var viSc = visitSchedule.Add(session, purpose, idDistributor, idCreator);
            if (viSc == null)
                return BadRequest();
            return CreatedAtAction("Add", viSc);
        }
        [HttpGet("Search")]
        public ActionResult Search(DateTime startDate, DateTime endDate, string status, int idDistributor)
        {
            return Ok(visitSchedule.Search(startDate, endDate, status, idDistributor));
        }
    }
}
