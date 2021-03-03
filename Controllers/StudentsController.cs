using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Data;
using TestApplication.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;

        public StudentsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentsDTO>>> GetStudents()
        {
            var student = from Students in _context.Students
            join Students_description in _context.Students_Description on Students.Id equals Students_description.Students_Id
            select new StudentsDTO
            {
                Students_Id = Students.Id,
                grade = Students.grade,
                First_name = Students_description.First_name,
                Last_name = Students_description.Last_name,
                Adresse = Students_description.Adresse,
                Country = Students_description.Country
                
            };

            return await student.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<StudentsDTO> GetStudents_byId(int id)
        {
            var student = from Students in _context.Students
            join Students_description in _context.Students_Description on Students.Id equals Students_description.Students_Id
            select new StudentsDTO
            {
                Students_Id = Students.Id,
                grade = Students.grade,
                First_name = Students_description.First_name,
                Last_name = Students_description.Last_name,
                Adresse = Students_description.Adresse,
                Country = Students_description.Country
                
            };

            var student_by_id = student.ToList().Find(x => x.Students_Id == id);

            if (student_by_id == null)
            {
                return NotFound();
            }
            return student_by_id;
        }
        
    }
}