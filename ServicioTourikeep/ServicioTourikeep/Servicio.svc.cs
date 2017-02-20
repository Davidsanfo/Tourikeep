using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioTourikeep
{
    // NOTE: You can use the "Rename" command on the "Refactor" ljkbhjlbllkjvbjlmenu to change the class name "Servicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Servicio.svc or Servicio.svc.cs at the Solution Explorer and start debugging.
    public class Servicio : IServicio
    {
        ModeloTourikeep modelo;
        public Servicio()
        {
            this.modelo = new ModeloTourikeep();
        }
        public SITIOS BuscarFotoEventos(int idsitioevento)
        {
            SITIOS sitios = this.modelo.BuscarFotoEventos(idsitioevento);
            return sitios;
        }

        public List<string> DividirCoordenadas(string coordenadas)
        {
            List<String> cordenadas = this.modelo.DividirCoordenadas(coordenadas);
            return cordenadas;
        }

        //public string FilaHorario(int sitio, string dia)
        //{
        //    String horario = this.modelo.FilaHorario(sitio, dia);
        //    return horario;
        //}

        public List<EVENTOS> GetEventos()
        {
            List<EVENTOS> eventos = this.modelo.GetEventos();
            return eventos;
        }

        //public List<EVENTOS_SITIOResult> GetEventosSitio()
        ////{
        //    throw new NotImplementedException();
        //}

        //public HORARIO_SITIODIAResult GetHorarios(int sitio, string dia)
        //{
        //    throw new NotImplementedException();
        //}

        public SITIOS GetMonumento(int? id)
        {
            SITIOS sitios = this.GetMonumento(id);
            return sitios;
        }

        public List<SITIOS> Sitios()
        {
            List<SITIOS> sitios = this.modelo.Sitios();
            return sitios;
        }
    }
}
