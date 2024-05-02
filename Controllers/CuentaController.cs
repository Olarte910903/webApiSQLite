using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaApiSQLite;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly InventarioContext _context;
        private readonly ICuentaService _cuentaContext;

        public CuentaController (InventarioContext context, ICuentaService cuentaContext)
        {
            _context = context;
            _cuentaContext = cuentaContext;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            var data = _context.cuentas.ToList();
            return Ok(data);
        }

        [HttpPost("sumar")]
        public IActionResult Addition(SumaNumero sumaNumero)
        {
            var elemento = _context.cuentas.FirstOrDefault();
            var suma = sumaNumero.NumeroSuma;
            var resultado = _cuentaContext.GetPlus(suma, elemento.Saldo);
            elemento.Saldo = resultado;
            _context.cuentas.Update(elemento);
            _context.SaveChanges();


            return Ok();
        }
        
        [HttpPost("restar")]
        public IActionResult Substraction(RestaNumero restaNumero)
        {
            var elemento = _context.cuentas.FirstOrDefault();
            var resta = restaNumero.NumeroResta;
            var resultado = _cuentaContext.GetSub(resta, elemento.Saldo);
            elemento.Saldo = resultado;
            _context.cuentas.Update(elemento);
            _context.SaveChanges();


            return Ok();
        }
    
    }
}
