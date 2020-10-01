using System;

using System.Collections.Generic;

using System.Data;
using System.Data.Entity;
using System.Linq;

using System.Web;
using MVCrepo2.Controllers;
using MVCrepo2.Models;



namespace MVCrepo2.repository

{

    public class traineesRepository : Itrainees

    {

        private Entities2 DBcontext;

        public traineesRepository(Entities2 objempcontext)

        {

            this.DBcontext = objempcontext;

        }

        public void InsertTrainees(Models.UserDetail User)

        {

            DBcontext.UserDetails.Add(User);

            DBcontext.SaveChanges();

        }

        public IEnumerable<Models.UserDetail> GetTrainees()

        {

            return DBcontext.UserDetails.ToList();

        }
        

        public UserDetail GetTraineesByID(int UserId)

        {

            return DBcontext.UserDetails.Find(UserId);

        }

       

        public void Save()
        {
            throw new NotImplementedException();
        }

        public UserDetail UpdateTrainees(UserDetail userDetail)
        {
            var userDtls = DBcontext.UserDetails.Where(x => x.UserId == userDetail.UserId).FirstOrDefault();

            userDtls.FullName = userDetail.FullName;
            userDtls.UserEmail = userDetail.UserEmail;
            userDtls.CivilIdNumber = userDetail.CivilIdNumber;
            userDtls.MobileNo = userDetail.MobileNo;
            DBcontext.SaveChanges();




            return DBcontext.UserDetails.Find(userDetail.UserId);
        }

        public UserDetail DeleteTrainees(int UserId)
        {
            return DBcontext.UserDetails.Find(UserId);
        }

        
    }

}