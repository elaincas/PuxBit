using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuxBit.Aplicacion.DTOS;
using PuxBit.Infraestructura.Core;
using Dominio.Entidades;

namespace PuxBit.Aplicacion.Servicios.GradosService
{
    public class GradoService : IGradoService
    {
        private readonly IRepositorioBase<Grados> _repositorioGrado;
        private readonly Respuesta _respuesta;
        public string mensaje = string.Empty;
        public GradoService(IRepositorioBase<Grados> repositorioGrado,
                            Respuesta respuesta)
        {
            _repositorioGrado = repositorioGrado;
            _respuesta = respuesta;
        }

        public Respuesta ActualizarGrado(GuardarGradosdto grado)
        {
            try
            {
                Grados gradoActualizar = AutoMapper.Mapper.Map<Grados>(grado);
                Grados gradoRegistroGuardado = _repositorioGrado.FirstOfDefault(x => x.ID == grado.ID);
                if (gradoActualizar.esEntidadValida(out mensaje))
                {

                    gradoRegistroGuardado = gradoActualizar;
                    _repositorioGrado.UnitofWork.SaveChanges();
                    return new Respuesta() { TipoRespuesta = RespuestaTipo.Ok, Mensaje = mensaje };
                }
                else
                    return new Respuesta() { TipoRespuesta = RespuestaTipo.Excepcion, Mensaje = mensaje };
            }
            catch (Exception ex)
            {
                return new Respuesta() { TipoRespuesta = RespuestaTipo.Error, Mensaje = ex.Message };
            }
        }

        public Respuesta GuardarGrado(GuardarGradosdto grado)
        {
            try
            {
                Grados gradoNuevo = AutoMapper.Mapper.Map<Grados>(grado);

                if (gradoNuevo.esEntidadValida(out mensaje))
                {

                    _repositorioGrado.Agregar(gradoNuevo);
                    _repositorioGrado.UnitofWork.SaveChanges();
                    return new Respuesta() { TipoRespuesta = RespuestaTipo.Ok, Mensaje = mensaje };
                }
                else
                    return new Respuesta() { TipoRespuesta = RespuestaTipo.Excepcion, Mensaje = mensaje };
            }
            catch (Exception ex)
            {
                return new Respuesta() { TipoRespuesta = RespuestaTipo.Error, Mensaje = ex.Message };
            }
        }

        public List<GuardarGradosdto> ObtenerGrados()
        {
            try
            {
                List<GuardarGradosdto> grados = AutoMapper.Mapper.Map<List<GuardarGradosdto>>( _repositorioGrado.Where(x => x.EsActivo == true));
                return grados;
             }
            catch (Exception ex)
            {

                return new List<GuardarGradosdto>();
            }
        }
    }
}
