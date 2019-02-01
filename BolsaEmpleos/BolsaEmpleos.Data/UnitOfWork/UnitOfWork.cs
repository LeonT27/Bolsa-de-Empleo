using System;
using BolsaEmpleos.Data.Model;
using BolsaEmpleos.Data.Repository;

namespace BolsaEmpleos.Data.UnitOfWork
{
    public class UnitOfWork: IDisposable
    {
        private BolsaEmpleosContext context = new BolsaEmpleosContext();
        private GenericRepository<Job> jobRepository;
        private GenericRepository<Categoria> categoriaRepository;

        public GenericRepository<Job> JobRepository
        {
            get
            {

                if (this.jobRepository == null)
                {
                    this.jobRepository = new GenericRepository<Job>(context);
                }
                return jobRepository;
            }
        }

        public GenericRepository<Categoria> CategoriaRepository
        {
            get
            {

                if (this.categoriaRepository == null)
                {
                    this.categoriaRepository = new GenericRepository<Categoria>(context);
                }
                return categoriaRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
