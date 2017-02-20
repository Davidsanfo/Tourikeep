using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioTourikeep
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicio" in both code and config file together.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        List<EVENTOS> GetEventos();

        //[OperationContract]
        //List<EVENTOS_SITIOResult> GetEventosSitio();

        [OperationContract]
        List<SITIOS> Sitios();

        [OperationContract]
        SITIOS GetMonumento(int? id);
        //sdñkfgvndsñ

        //[OperationContract]
        //HORARIO_SITIODIAResult GetHorarios(int sitio, String dia);

        [OperationContract]
        String FilaHorario(int sitio, String dia);

        [OperationContract]
        List<String> DividirCoordenadas(String coordenadas);

        [OperationContract]
        SITIOS BuscarFotoEventos(int idsitioevento);
        
    }
}
