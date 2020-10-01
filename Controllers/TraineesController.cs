using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Mvc;
using MVCrepo2.Models;
using MVCrepo2.repository;



namespace MVCrepo2.Controllers

{

    public class TraineesController : Controller

    {
        private Itrainees Itrn;
        

        public TraineesController()

        {

            this.Itrn = new traineesRepository(new Entities2());
            
        }
        
        

        public ActionResult Index()

        {

            var list = Itrn.GetTrainees().ToList();
           

            return View(list);
        }

        

        public ActionResult Details(int id)

        {

            var objtrn = Itrn.GetTraineesByID(id);
            var User = new UserDetail();
            User.UserId = id;
            User.FullName = objtrn.FullName;
            User.UserEmail = objtrn.UserEmail;
            User.CivilIdNumber = objtrn.CivilIdNumber;
            User.PasswordHash = objtrn.PasswordHash;
            User.MobileNo = objtrn.MobileNo;
            User.RoleId = objtrn.RoleId;
            User.Address = objtrn.Address;
            User.Area = objtrn.Area;
            User.CreatedDate = objtrn.CreatedDate;
            User.ModifiedDate = objtrn.ModifiedDate;
            User.DeviceId = objtrn.DeviceId;
            User.DeviceType = objtrn.DeviceType;
            User.Housing = objtrn.Housing;
            User.Street = objtrn.Street;
            User.Block = objtrn.Block;
            User.FcmToken = objtrn.FcmToken;
            User.VerifiedBy = objtrn.VerifiedBy;
            User.verify = objtrn.verify;
            return View(User);

        }

        [HttpGet]
        public ActionResult Create()

        {

            return View(new UserDetail());

        }


        [HttpPost]

        public ActionResult Create(FormCollection collection, UserDetail objtrn)

        {

            try

            {
             
                var User = new UserDetail();
                User.UserId = 4429;
                User.FullName = objtrn.FullName;
                User.UserEmail = objtrn.UserEmail;
                User.PasswordHash = objtrn.PasswordHash;
                User.CivilIdNumber = objtrn.CivilIdNumber;
                User.DOB = objtrn.DOB;
                User.MobileNo = objtrn.MobileNo;
                User.Address = objtrn.Address;
                User.RoleId = objtrn.RoleId;
                User.ProfilePic = objtrn.ProfilePic;
                User.CreatedDate = objtrn.CreatedDate;
                User.ModifiedDate = objtrn.ModifiedDate;
                User.IsNotificationActive = objtrn.IsNotificationActive;
                User.IsActive = objtrn.IsActive;
                User.DeviceId = objtrn.DeviceId;
                User.DeviceType = objtrn.DeviceType;
                User.FcmToken = objtrn.FcmToken;
                User.verify = objtrn.verify;
                User.VerifiedBy = objtrn.VerifiedBy;
                User.Area = objtrn.Area;
                User.Block = objtrn.Block;
                User.Street = objtrn.Street;
                User.Housing = objtrn.Housing;
                User.Floor = objtrn.Floor;
                User.NewPass = objtrn.NewPass;
                User.ConPass = objtrn.ConPass;
                User.Jadda = objtrn.Jadda;
                User.Reason = objtrn.Reason;
                User.ActivatedBy = objtrn.ActivatedBy;
                User.VerifiedDate = objtrn.VerifiedDate;
                User.ActivatedDate = objtrn.ActivatedDate;
                Itrn.InsertTrainees(User);
                return RedirectToAction("Index");
          
            }

            catch

            {

                return View();

            }

        }

        
        [HttpGet]
        public ActionResult Edit(int id)

        {
            var objtrn = Itrn.GetTraineesByID(id);
            var User = new UserDetail();
            User.UserId = id;
            User.FullName = objtrn.FullName;
            User.UserEmail = objtrn.UserEmail;
            User.PasswordHash = objtrn.PasswordHash;
            User.CivilIdNumber = objtrn.CivilIdNumber;
            User.DOB = objtrn.DOB;
            User.MobileNo = objtrn.MobileNo;
            User.Address = objtrn.Address;
            User.RoleId = objtrn.RoleId;
            User.ProfilePic = objtrn.ProfilePic;
            User.CreatedDate = objtrn.CreatedDate;
            User.ModifiedDate = objtrn.ModifiedDate;
            User.IsNotificationActive = objtrn.IsNotificationActive;
            User.IsActive = objtrn.IsActive;
            User.DeviceId = objtrn.DeviceId;
            User.DeviceType = objtrn.DeviceType;
            User.FcmToken = objtrn.FcmToken;
            User.verify = objtrn.verify;
            User.VerifiedBy = objtrn.VerifiedBy;
            User.Area = objtrn.Area;
            User.Block = objtrn.Block;
            User.Street = objtrn.Street;
            User.Housing = objtrn.Housing;
            User.Floor = objtrn.Floor;
            User.NewPass = objtrn.NewPass;
            User.ConPass = objtrn.ConPass;
            User.Jadda = objtrn.Jadda;
            User.Reason = objtrn.Reason;
            User.ActivatedBy = objtrn.ActivatedBy;
            User.VerifiedDate = objtrn.VerifiedDate;
            User.ActivatedDate = objtrn.ActivatedDate;
            return View(User);


        }

        

        [HttpPost]

        public ActionResult Edit(int id, FormCollection collection, UserDetail Objtrn)

        {

            try

            {

                // var objtrn = Itrn.UpdateTrainees(id);
                var a = Itrn.UpdateTrainees(Objtrn.UserId);
                return RedirectToAction("Index");




            }

            catch

            {

                return View();

            }

        }

       [HttpGet]
        public ActionResult Delete(int id)

        {
            var Objtrn = Itrn.GetTraineesByID(id);

            return View(Objtrn);

        }


        [HttpPost]

        public ActionResult Delete(int id, UserDetail Objtrn)

        {

            try

            {
                Itrn.DeleteTrainees(id);

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }

        }

    }

}