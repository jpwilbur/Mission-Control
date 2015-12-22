using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;
using MVCProject1.DAL;

namespace MVCProject1.Controllers
{
    public class MissionsController : Controller
    {
        private MissionControlContext db = new MissionControlContext();
        // GET: Missions
        public ActionResult Index()
        {
            return View(db.Mission.ToList());
        }

        public ViewResult Mission (int id)
        {
            MissionModel model = db.Mission.Find(id);

            ViewBag.userID = User.Identity.Name;
 
            return View(model);
        }

        [HttpPost]
        public ActionResult Question(FormCollection form, int missionid, string email)
        {
            if (form["Question"] == "")
            {
                return RedirectToAction("Mission", "Missions", new { id = missionid });
            }
            else
            {
                var userid = db.Database.SqlQuery<int>("SELECT userID FROM [User] WHERE userEmail = '" + email + "';").Single();

                MissionQuestionModels missionquestion = new MissionQuestionModels();
                missionquestion.answer = "This question has not been answered. Reply to answer it!";
                missionquestion.question = form["Question"].ToString();
                missionquestion.MissionID = missionid;
                missionquestion.userID = userid;

                db.MissionQuestion.Add(missionquestion);
                db.SaveChanges();

                return RedirectToAction("Mission", "Missions", new { id = missionid });
            }
        }

        [HttpPost]
        public ActionResult Reply(FormCollection form, int id, int missionid)
        {
            //MissionQuestionModels missionquestion = db.MissionQuestion.Find(id);
            //missionquestion.answer = form["Reply here"].ToString();

            //db.MissionQuestion.Add(missionquestion);
            //db.SaveChanges();

            if (form["Reply here"] == "")
            {
                return RedirectToAction("Mission", "Missions", new { id = missionid });
            }
            else
            {
                MissionQuestionModels missionquestion = db.MissionQuestion.FirstOrDefault(x => x.missionQuestionID == id);
                missionquestion.answer = form["Reply here"].ToString();
                db.SaveChanges();
            }

            return RedirectToAction("Mission", "Missions", new { id = missionid });
        }
    }
}