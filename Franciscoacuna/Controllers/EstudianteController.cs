using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace Franciscoacuna.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudianteController : ControllerBase
    {

        private string connection = @"Server=localhost; Database=adminestudiantes; Uid=root;";

        [HttpGet]
        public IActionResult get()
        {
            List<Models.Estudiante> lst = null;
            using (var db = new MySqlConnection(connection))
            {
                db.Open();
                var sql = "select Id,Nombres,apellidos,Genero,FechaCreacion,FechaActualizacion,EstadoBorrado,FechaNacimiento from estudiante";
                lst = (List<Models.Estudiante>)db.Query<Models.Estudiante>(sql);

            }

            return Ok(lst);

        }

        /// <summary>
        /// Insert the new student in system
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult insertEstudiante (Models.Estudiante model)
        {
            int result = 0;
            using (var db= new MySqlConnection(connection))
            {
                var sql = "INSERT into estudiante(Nombres,apellidos,Genero,FechaCreacion,FechaActualizacion,EstadoBorrado,FechaNacimiento)" + 
                    "values(@Nombres,@apellidos,@Genero,@FechaCreacion,@FechaActualizacion,@EstadoBorrado,@FechaNacimiento)";
            }

            return Ok(result);
        }
        /// <summary>
        /// update 
        /// </summary>
        [HttpPut]
        public IActionResult updateEstudiante(Models.Estudiante model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "UPDATE estudiante set Nombres=@nombres,@FechaActualizacion where Id=@id";

                result = db.Execute(sql, model);
            }

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult deleteEstudiante(Models.Estudiante model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "DELETE from estudiante where Id=@id ";

                result = db.Execute(sql, model);

            }

            return Ok(result);
        }
    } 
}
