using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace threetiercrud
{
    public class EmployeeBAL
    {
        public int Insert(EmployeeSchema objSchema)
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.InsertData(objSchema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(EmployeeSchema objSchema, int Id)
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.UpdateData(objSchema, Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(int Id)
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.DeleteData(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BindGrid()
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.BindGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetById(int Id)
        {
            try
            {
                EmployeeDAL objDAL = new EmployeeDAL();
                return objDAL.GetById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
