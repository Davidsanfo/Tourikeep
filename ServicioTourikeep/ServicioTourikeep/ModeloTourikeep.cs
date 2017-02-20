using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioTourikeep
{
    public class ModeloTourikeep
    {
        Entities entidad;

        public ModeloTourikeep()
        {
            entidad = new Entities();
        }
        public List<EVENTOS> GetEventos()
        {
            var consulta = from datos in entidad.EVENTOS select datos;
            return consulta.ToList();
        }
        //public List<EVENTOS_SITIOResult> GetEventosSitio()
        //{
        //    var consulta = this.entidad.EVENTOS_SITIO().ToList();

        //    return consulta;
        //}
        public List<SITIOS> Sitios()
        {
            var consulta = from datos in entidad.SITIOS select datos;
            return consulta.ToList();
        }
        public SITIOS GetMonumento(int? id)
        {
            var consulta = from datos in entidad.SITIOS where datos.Id_sitio == id select datos;
            return consulta.First();
        }
        //public HORARIO_SITIODIAResult GetHorarios(int sitio, String dia)
        //{
        //    var consulta = (this.entidad.HORARIO_SITIODIA(sitio, dia)).ToList();

        //    if (consulta.Count() == 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return consulta.First();
        //    }
        //}
        //public String FilaHorario(int sitio, String dia)
        //{
        //    String horarioDia = "";
        //    String diahoy = DateTime.Now.DayOfWeek.ToString();
        //    switch (diahoy)
        //    {
        //        case "Monday":
        //            diahoy = "Lunes";
        //            break;
        //        case "Tuesday":
        //            diahoy = "Martes";
        //            break;
        //        case "Wednesday":
        //            diahoy = "Miércoles";
        //            break;
        //        case "Thursday":
        //            diahoy = "Jueves";
        //            break;
        //        case "Friday":
        //            diahoy = "Viernes";
        //            break;
        //        case "Saturday":
        //            diahoy = "Sábado";
        //            break;
        //        case "Sunday":
        //            diahoy = "Domingo";
        //            break;
        //    }
        //    var consultar = this.GetHorarios(sitio, dia);
        //    if (dia == diahoy)
        //    {
        //        horarioDia += "<b class='bold-dia'>";
        //        if (consultar == null)
        //        {
        //            horarioDia += dia + ": Cerrado.</b>";
        //        }
        //        else if (consultar.Hora_apertura == "00:00" && consultar.Hora_cierre == "23:59</b>")
        //        {
        //            horarioDia += dia + ": Abierto 24h.</b>";
        //        }
        //        else
        //        {
        //            horarioDia += dia + ": " + consultar.Hora_apertura + "–" + consultar.Hora_cierre + "</b>";
        //        }
        //    }
        //    else
        //    {
        //        if (consultar == null)
        //        {
        //            horarioDia += dia + ": Cerrado.";
        //        }
        //        else if (consultar.Hora_apertura == "00:00" && consultar.Hora_cierre == "23:59")
        //        {
        //            horarioDia += dia + ": Abierto 24h.";
        //        }
        //        else
        //        {
        //            horarioDia += dia + ": " + consultar.Hora_apertura + "–" + consultar.Hora_cierre;
        //        }
        //    }
        //    return horarioDia;
        //}
        public List<String> DividirCoordenadas(String coordenadas)
        {
            string[] separators = { "," };
            string[] words = coordenadas.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.ToList();
        }
        public SITIOS BuscarFotoEventos(int idsitioevento)
        {
            var consulta = from datos in entidad.SITIOS
                           where datos.Id_sitio == idsitioevento
                           select datos;
            return consulta.First();
        }
    }
}