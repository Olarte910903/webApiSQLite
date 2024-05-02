using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace practicaApiSQLite;

public class CuentaService : ICuentaService
{
    public int GetPlus (int suma, int saldoCuenta)
    {
        return suma + saldoCuenta;
    }

    public int GetSub (int resta, int saldoCuenta)
    {
        return saldoCuenta - resta;
    }
}
