using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataLayer.Model;
using DataLayer.Repository;
using System.Data.Entity;
namespace UnitOfWork
{
    public class UnitOfWorkDB : IDisposable
    {

        private LensManagementEntities _db;
        private Exception _exception;
        public UnitOfWorkDB()
        {
            _db = new LensManagementEntities();
        }

        public Repository<Lens> LensRepository
        {

            get
            {
                return new Repository<Lens>(_db); ;
            }
        }

        public Repository<Section> SectionRepository
        {

            get
            {
                return new Repository<Section>(_db); ;
            }
        }

        public Repository<User> UserRepository
        {

            get
            {
                return new Repository<User>(_db); ;
            }
        }


        public bool Save()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _exception = ex;
                return false;
            }
        }


        public void Dispose()
        {
            _db.Dispose();
        }




    }
}
