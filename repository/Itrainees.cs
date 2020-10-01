using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MVCrepo2.Models;



namespace MVCrepo2.repository

{

    interface Itrainees

    {

        void InsertTrainees(UserDetail user); 

        IEnumerable<UserDetail> GetTrainees();


        UserDetail GetTraineesByID(int UserId);

        UserDetail UpdateTrainees(UserDetail userDetail);

        UserDetail DeleteTrainees(int UserId);

        void Save();
        //object UpdateTrainees(int userId);
    }

}