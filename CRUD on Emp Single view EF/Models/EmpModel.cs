using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_on_Emp_Single_view_EF.Models
{
    public class EmpModel
    {
        public int Eno { get; set; }
        public string Ename { get; set; }
        public int Esal { get; set; }
     
        mydbEntities objef = new mydbEntities();
        public IQueryable GetEmp()
        {
            return objef.emps;
        }
        public int InsertEmp()
        {
            emp objemp = new emp();
            objemp.empno = Eno;
            objemp.empname = Ename;
            objemp.sal = Esal;
            try
            {
               
                objef.emps.Add(objemp);
                objef.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteEmp()
        {
            emp objemp = objef.emps.Find(Eno);
            try
            {
                objef.emps.Remove(objemp);
                objef.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int UpdateEmp()
        {
            emp objemp = objef.emps.Find(Eno);
           
            try
            {
                objemp.sal = Esal;
                objef.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}