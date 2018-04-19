using PuxBit.Aplicacion.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuxBit.Aplicacion.Servicios.GradosService
{
    public interface IGradoService
    {
        Respuesta GuardarGrado(GuardarGradosdto grado);
        Respuesta ActualizarGrado(GuardarGradosdto grado);
        List<GuardarGradosdto> ObtenerGrados();

        GuardarGradosdto BuscarGradoPorID(int ID);
    }
}
