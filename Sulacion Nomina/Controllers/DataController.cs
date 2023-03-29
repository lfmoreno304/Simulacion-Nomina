using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sulacion_Nomina.Models;

namespace Sulacion_Nomina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpPost]
        [Route("simulate")]
        public dynamic simulateSalary([FromBody] List<Teacher> teachers) {
            double salary=0,SMMLV= 1160000;
            foreach (var teacher in teachers) {
                if (teacher.type == "catedratico")
                {
                    switch (teacher.category)
                    {
                        case "auxiliarT":
                            salary += (teacher.hours * 20142);
                            break;
                        case "auxiliarM":
                            salary += (teacher.hours * 20142);
                            break;
                        case "asistenteT":
                            salary += (teacher.hours * 28422);
                            break;
                        case "asistenteM":
                            salary += (teacher.hours * 28422);
                            break;
                        case "asociadoT":
                            salary += (teacher.hours * 35314);
                            break;
                        case "asociadoM":
                            salary += (teacher.hours * 35314);
                            break;
                        case "titularT":
                            salary += (teacher.hours * 37896);
                            break;
                        case "titularM":
                            salary += (teacher.hours * 37896);
                            break;
                    }
                }
                else {
                    switch (teacher.category)
                    {
                        case "auxiliarT":
                            salary += (SMMLV * 2.645);
                            break;
                        case "auxiliarM":
                            salary += (SMMLV * 1.509);
                            break;
                        case "asistenteT":
                            salary += (SMMLV * 3.125);
                            break;
                        case "asistenteM":
                            salary += (SMMLV * 1.749);
                            break;
                        case "asociadoT":
                            salary += (SMMLV * 3.606);
                            break;
                        case "asociadoM":
                            salary += (SMMLV * 1.99);
                            break;
                        case "titularT":
                            salary += (SMMLV * 3.918);
                            break;
                        case "titularM":
                            salary += (SMMLV * 2.146);
                            break;
                    }
                }

                switch (teacher.postGraduate) {
                    case "especializacion":
                        salary += SMMLV * 0.1;
                        break;
                    case "maestria":
                        salary += SMMLV * 0.45;
                        break;
                    case "doctorado":
                        salary += SMMLV * 0.9;
                        break;
                    case "postdoctorado":
                        salary += SMMLV * 1;
                        break;
                }
                switch (teacher.group)
                {
                    case "A1":
                        salary += SMMLV * 0.56;
                        break;
                    case "A":
                        salary += SMMLV * 0.47;
                        break;
                    case "B":
                        salary += SMMLV * 0.42;
                        break;
                    case "C":
                        salary += SMMLV * 0.38;
                        break;
                    case "colciencias":
                        salary += SMMLV * 0.33;
                        break;
                    case "semillero":
                        salary += SMMLV * 0.19;
                        break;
                }

            }
            return new JsonResult(salary);  
        }
    }
}
