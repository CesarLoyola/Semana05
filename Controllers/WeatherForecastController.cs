using Microsoft.AspNetCore.Mvc;

namespace webapii.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("DevolverValor")]
        public int DevolverValor()
        {

            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;
            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num3;

        }

        [HttpGet("DevolverSaludo")]
        public string DevolverSaludo()
        {

            string variable1 = "Pedro";
            string variable2 = "Juan";
            string variable3 = variable1 + variable2;
            int num1 = 7;
            string variable4 = variable3 + num1.ToString();
            string mensaje = "Hola " + variable4;
            return mensaje;

        }

        [HttpGet("DevolverEstado/{edad}/{nombre}")]
        public string DevolverEstado(int edad, string nombre)
        {
            string mensaje = " ";

            if (edad >= 18)
            {
                mensaje = "Sr(a) " + nombre + " es mayor de edad";
            }
            else
            {
                mensaje = "Sr(a) " + nombre + " es menor de edad";
            }
            return mensaje; 

        }

        [HttpGet("DevolverAlumno")]
        public string DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "4370258");

            return Alumno2.DevolverNombreCompleto();
        }

        [HttpGet("DevolverDNI")]
        public string DevolverDNI()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "4370258");

            return Alumno2.DevolverDNI();
        }

        [HttpGet("DevolverEdad")]
        public int DevolverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Cesar", "Loyola", "4370258", new DateTime(2002, 8, 19));
            string numero = "siete";
            return Alumno3.DevolverEdad();
        }

    }
}
