using StudentCatalog2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCatalog2016.Repositories
{
    // in c# as default it is private, so specify that it should be public
    public interface IStudenrepository
    {
        // GetAll() (should return all the students)
        IEnumerable<Student> Getall();

        // Find - (should return one student beased on id)
        Student Find(int id);

        // Delete (shoudl delete a student based on id)
        void Delete();

        // InsertOrUpdate (should insert or update a student to the db)
        void InsertOrUpdate(Student student);


    }
}
