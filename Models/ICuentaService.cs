using Microsoft.AspNetCore.Mvc;

namespace practicaApiSQLite;

public interface ICuentaService
{
    public int GetPlus(int suma, int valorCuenta);
    public int GetSub(int resta, int valorCuenta);
}