using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCatalog2016.Models;

namespace StudentCatalog2016.Repositories
{
    public class StudentRepository : IStudenrepository
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Student Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> Getall()
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Student student)
        {
            if (student.Id == default(int))
            {

            }
        }
    }
}