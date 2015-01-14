using KnockOutTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOutTest.Controllers
{
    public class TrainingController : Controller
    {
        private TrainingManager _trainingManager;

        public TrainingController()
        {
            _trainingManager = new TrainingManager();
        }

        public JsonResult GetAllTrainings()
        {
            IQueryable<Training> trainings = _trainingManager.GetTrainings().AsQueryable();

            return Json(trainings, JsonRequestBehavior.AllowGet);
        }

        public JsonResult InitializePageData()
        {
            var form = _trainingManager.CreateTrainingForm();

            return Json(form, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTrainingById(int id)
        {
            var training = _trainingManager.FindProfileById(id);

            return Json(training, JsonRequestBehavior.AllowGet);
        }

        // GET: Training
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateEdit()
        {
            return View();
        }
    }

    public class TrainingManager
    {
        private List<Training> _trainings = new List<Training>();

        public TrainingManager()
        {
            _trainings.Add(new Training
            {
                TrainingId = 1,
                Name = "Test",
                TrainingDateTimes = new List<TrainingDateTime>()
                {
                    new TrainingDateTime("startdate","enddate"),
                    new TrainingDateTime("startdate2","enddate2"),
                    new TrainingDateTime("startdate3","enddate3")
                }
            });

            _trainings.Add(new Training
            {
                TrainingId = 2,
                Name = "Training 2",
                TrainingDateTimes = new List<TrainingDateTime>(){
                    new TrainingDateTime("startdate", "enddate"),
                    new TrainingDateTime("startdate2", "enddate2")
                }
            });
        }

        public List<Training> GetTrainings()
        {
            return _trainings;
        }

        public Training FindProfileById(int id)
        {
            Training training = _trainings.Find(t => t.TrainingId == id);

            if (training != null)
            {
                return training;
            }

            return new Training();
        }

        public TrainingForm CreateTrainingForm()
        {
            return new TrainingForm
            {
                Dates = new List<TrainingDateTime>()
            };
        }
    }

    public class TrainingForm
    {
        public List<TrainingDateTime> Dates { get; set; }
    }
}