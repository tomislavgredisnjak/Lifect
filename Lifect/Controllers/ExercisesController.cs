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
    public class ExercisesController : ApiController
    {
        private GymBase db = new GymBase();

        // GET: api/Exercises
        public IQueryable<Exercise> GetExercise()
        {
            return db.Exercise;
        }

        // GET: api/Exercises/5
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult GetExercise(int id)
        {
            Exercise exercise = db.Exercise.Find(id);
            if (exercise == null)
            {
                return NotFound();
            }

            return Ok(exercise);
        }

        // PUT: api/Exercises/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExercise(int id, Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != exercise.Id_Exercise)
            {
                return BadRequest();
            }

            db.Entry(exercise).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExerciseExists(id))
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

        // POST: api/Exercises
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult PostExercise(Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Exercise.Add(exercise);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = exercise.Id_Exercise }, exercise);
        }

        // DELETE: api/Exercises/5
        [ResponseType(typeof(Exercise))]
        public IHttpActionResult DeleteExercise(int id)
        {
            Exercise exercise = db.Exercise.Find(id);
            if (exercise == null)
            {
                return NotFound();
            }

            db.Exercise.Remove(exercise);
            db.SaveChanges();

            return Ok(exercise);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExerciseExists(int id)
        {
            return db.Exercise.Count(e => e.Id_Exercise == id) > 0;
        }
    }
}