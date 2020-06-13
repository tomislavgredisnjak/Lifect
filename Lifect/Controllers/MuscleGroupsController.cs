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
using Lifect.Models;

namespace Lifect.Controllers
{
    public class MuscleGroupsController : ApiController
    {
        private GymBase db = new GymBase();

        // GET: api/MuscleGroups
        public IQueryable<MuscleGroup> GetMuscleGroups()
        {
            return db.MuscleGroups;
        }

        // GET: api/MuscleGroups/5
        [ResponseType(typeof(MuscleGroup))]
        public IHttpActionResult GetMuscleGroup(int id)
        {
            MuscleGroup muscleGroup = db.MuscleGroups.Find(id);
            if (muscleGroup == null)
            {
                return NotFound();
            }

            return Ok(muscleGroup);
        }

        // PUT: api/MuscleGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMuscleGroup(int id, MuscleGroup muscleGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != muscleGroup.Id_MuscleGroup)
            {
                return BadRequest();
            }

            db.Entry(muscleGroup).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MuscleGroupExists(id))
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

        // POST: api/MuscleGroups
        [ResponseType(typeof(MuscleGroup))]
        public IHttpActionResult PostMuscleGroup(MuscleGroup muscleGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MuscleGroups.Add(muscleGroup);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = muscleGroup.Id_MuscleGroup }, muscleGroup);
        }

        // DELETE: api/MuscleGroups/5
        [ResponseType(typeof(MuscleGroup))]
        public IHttpActionResult DeleteMuscleGroup(int id)
        {
            MuscleGroup muscleGroup = db.MuscleGroups.Find(id);
            if (muscleGroup == null)
            {
                return NotFound();
            }

            db.MuscleGroups.Remove(muscleGroup);
            db.SaveChanges();

            return Ok(muscleGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MuscleGroupExists(int id)
        {
            return db.MuscleGroups.Count(e => e.Id_MuscleGroup == id) > 0;
        }
    }
}