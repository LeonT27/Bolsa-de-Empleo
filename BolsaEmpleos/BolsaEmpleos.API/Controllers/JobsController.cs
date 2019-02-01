using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BolsaEmpleos.Data.Model;
using BolsaEmpleos.Data.UnitOfWork;

namespace BolsaEmpleos.API.Controllers
{
    public class JobsController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: api/Jobs
        public IEnumerable<Job> GetJobs()
        {
            return unitOfWork.JobRepository.Get();
        }

        // GET: api/Jobs/5
        [ResponseType(typeof(Job))]
        public IHttpActionResult GetJob(int id)
        {
            Job job = unitOfWork.JobRepository.GetByID(id);
            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        // PUT: api/Jobs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJob(int id, Job job)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != job.Id_Job)
            {
                return BadRequest();
            }

            unitOfWork.JobRepository.Update(job);

            try
            {
                unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Jobs
        [ResponseType(typeof(Job))]
        public IHttpActionResult PostJob(Job job)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitOfWork.JobRepository.Insert(job);
            unitOfWork.Save();

            return CreatedAtRoute("DefaultApi", new { id = job.Id_Job }, job);
        }

        // DELETE: api/Jobs/5
        [ResponseType(typeof(Job))]
        public IHttpActionResult DeleteJob(int id)
        {
            Job job = unitOfWork.JobRepository.GetByID(id);
            if (job == null)
            {
                return NotFound();
            }

            unitOfWork.JobRepository.Delete(job);
            unitOfWork.Save();

            return Ok(job);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JobExists(int id)
        {
            return unitOfWork.JobRepository.Count(e => e.Id_Job == id) > 0;
        }
    }
}