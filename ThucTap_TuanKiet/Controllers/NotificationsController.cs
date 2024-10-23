﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucTap_TuanKiet.Model;
using ThucTap_TuanKiet.Services;

namespace ThucTap_TuanKiet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotification notification;
        public NotificationsController(INotification notification)
        {   
            this.notification = notification;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(notification.NotificationList());
        }
        [HttpGet("ByCreator/{idCreator}")]
        public ActionResult GetByIdCreator(int idCreator)
        {
            return Ok(notification.GetByIdAccount(idCreator));
        }
        [HttpGet("ByReceiver/{idReceiver}")]
        public ActionResult GetByIdReceiver(int idReceiver)
        {
            return Ok(notification.GetByIdReceiver(idReceiver));
        }
        [HttpGet("{idNoti}")]
        public ActionResult GetNoti(int idNoti)
        {
            return Ok(notification.GetNotification(idNoti));
        }
        [HttpPost]
        public ActionResult Add(string title, string content, int idCreator, string status)
        {
            var noti = notification.AddNotification(title, content, idCreator, status);
            if (noti == null)
                return BadRequest();
            return CreatedAtAction("Add", noti);
        }
        [HttpGet]
        [Route("Search")]
        public ActionResult Searh(string keyword)
        {
            return Ok(notification.SearchNotification(keyword));
        }
    }
}
