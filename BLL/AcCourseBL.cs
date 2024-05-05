/*using GeoMapping.Common;
using GeoMapping.DTO;
using GeoMapping.Helper;
using GeoMapping.Interfaces;
using GeoMapping.Models;
using GeoMapping.Repositories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoMapping.BL
{
    public class GeoAddressBLL : DTOMapper
    {
        private IGeoAddressRepository repository = null;
        private readonly IConfiguration _configuration;
        public GeoAddressBLL()
        {

            this.repository = new AcademicCoursesRepository();
        }

        public async Task<Course> AddAcCourse(AcademicCourseDTO academicCourseDTO)
        {
            var obj = DTOMapper.mapper.Map<Course>(academicCourseDTO);

            return await repository.AddacCourse(obj);


        }
        public async Task<List<AcademicCourseDTO>> GetAcCourss()
        {
            var academicCourse = await repository.GetAllCourses();

            var objDTO = DTOMapper.mapper.Map<List<AcademicCourseDTO>>(academicCourse);
            return objDTO;
        }

        public async Task<AcademicCourseDTO> GetCourseById(int courseId)
        {
            var academicCourse = await repository.GetCourseById(courseId);

            var objDTO = DTOMapper.mapper.Map<AcademicCourseDTO>(academicCourse);
            return objDTO;
        }

    }
}

*/