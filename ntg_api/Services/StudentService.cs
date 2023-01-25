using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ntg_api.Data;
using ntg_api.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntg_api.Services
{
    public interface IStudentService {
        Task<int>AddStudent(Student  student);
       
        Task<int> UpdateStudent(Student student);
        //Task<IEnumerable<Student>> GetStuddent();
        Task<IEnumerable<Student>> GetStuddent();
    }
    public class StudentService : IStudentService
    {
        private readonly AplicationDbContext _aplicationDbContext;
        private readonly IMapper _mapper;
        public StudentService(AplicationDbContext aplicationDbContext,IMapper mapper)
        {
            this._aplicationDbContext = aplicationDbContext;
            _mapper = mapper;
        }
        public async Task<int> AddStudent(Student student)
            
        {
            var item = await _aplicationDbContext.students.AddAsync(student);
           
            await _aplicationDbContext.SaveChangesAsync();
           return item.Entity.Id;
            
        }


        public async Task<IEnumerable<Student>> GetStuddent()
        {

            return await _aplicationDbContext.students.ToListAsync();

        }



        public async Task<int> UpdateStudent(Student student)
        {
           var item = await _aplicationDbContext.students.FirstOrDefaultAsync(x=>x.Id==student.Id);
            item.CourseTeacherId = student.CourseTeacherId;

            await _aplicationDbContext.SaveChangesAsync();
            return item.Id;
        }
    }
}
