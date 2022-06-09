using System;
using System.Data;
using Decor_Register.Controller;
using Decor_Register.Entidades;

namespace Decor_Register.Model
{
    class UserModel
    {
        UserController userController = new UserController();
        DataTable dt = new DataTable();

        public DataTable ProdList()
        {
            try
            {
                dt = userController.ProdList();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Save(User usuario)
        {
            try
            {
                userController.Save(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(User usuario)
        {
            try
            {
                userController.Delete(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Edit(User usuario)
        {
            try
            {
                userController.Edit(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
