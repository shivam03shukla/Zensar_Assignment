using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Context;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbObj = new db_testEntities();
        public ActionResult Student(tbl_Student obj)
        {
            if (obj != null)
                return View(obj);
            else
                return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            if (ModelState.IsValid)
            {

                obj.Hno = model.Hno;
                obj.name = model.name;
                obj.familyname = model.familyname;
                obj.address = model.address;
                obj.city = model.city;
                obj.zipcode = model.zipcode;
                obj.phone = model.phone;
                obj.email = model.email;
                if (model.Hno == 0)
                {
                    dbObj.tbl_Student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    dbObj.SaveChanges();
                }
               
            }
            ModelState.Clear();
            return View("Student");
        }

        public ActionResult StudentList()
        {
            var res = dbObj.tbl_Student.ToList();
            return View(res);
        }
        public ActionResult Delete(int Hno)
        {
            var res = dbObj.tbl_Student.Where(x => x.Hno == Hno).First();
            dbObj.tbl_Student.Remove(res);
            dbObj.SaveChanges();
            var list = dbObj.tbl_Student.ToList();

            return View("StudentList",list);
        }
    }
}