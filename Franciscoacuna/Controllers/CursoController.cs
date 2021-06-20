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
    public class CursoController : ControllerBase
    {
        private string connection = @"Server=localhost; Database=adminestudiantes; Uid=root;";

        [HttpGet]
        public IActionResult get()
        {
            List<Models.Curso> lst = null;
            using (var db = new MySqlConnection(connection))
            {

                var sql = "SELECT Nombrecurso, CodigoCurso , estaBorrado, FechaCreacion, FechaActualizacion from Curso ";
                lst = (List<Models.Curso>)db.Query<Models.Curso>(sql);

            }

            return Ok(lst);
        }

        [HttpPost]
        public IActionResult insertCurso(Models.Curso model)
        {
            int result = 0;
            int idstu = 0;
            List<Models.Curso> lstid = null;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "INSERT into Curso()" + "values()";
                var sql2 = "SELECT idcurso from Curso ";
                lstid = (List<Models.Curso>)db.Query<Models.Curso>(sql);
                var sql3 = "INSERT into EstudianteCurso()" + "values(idstu,lstid)";
            }

            return Ok(result);
        }

        [HttpPut]
        public IActionResult updateCurso(Models.Curso model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "UPDATE Curso set Nombrecurso=@nombrecurso";
                result = db.Execute(sql, model);
            }
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult deleteCurso(Models.Curso model)
        {
            int result = 0;
            using (var db = new MySqlConnection(connection))
            {
                var sql = "DELETE from Curso where id=@id";
                result = db.Execute(sql, model);
            }
                return Ok(result);
        }
    }
}
