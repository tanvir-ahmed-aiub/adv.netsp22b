﻿using BLL.Entities;
using DAL;
using DAL.Database;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static StudentModel Get(int id) {
            var st = DataAccessFactory.StudentDataAccess().Get(id);
            var auth = DataAccessFactory.AuthDataAccess().Authenticate("","");
            return new StudentModel() { 
                Id= st.Id,
                Name = st.Name,
                DepartmentId = st.DepartmentId
            };
        }
    }
}