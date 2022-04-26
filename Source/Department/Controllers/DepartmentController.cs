using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department.Model;

namespace Department.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase{
        internal static ILogger<DepartmentController> _logger;
        public DepartmentController(ILogger<DepartmentController> _logger)
        {
            _logger.LogInformation("Department List Is Displaying,..........");
        }
        [HttpGet]
        public string[] GetDepartment()
        {
            string[] department = { "DotNet", "Java", "Lamp", "BFS"};
            return department;
        }

        [HttpDelete]
        public void DeleteDepartment(){
            
        }
    }
}