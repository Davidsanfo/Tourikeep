//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioTourikeep
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class COMENTARIOS
    {
        [DataMember]
        public int Id_comentario { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Fecha { get; set; }
        [DataMember]
        public Nullable<double> Valoracion { get; set; }
        [DataMember]
        public string Comentario { get; set; }
        [DataMember]
        public Nullable<int> Id_sitio { get; set; }
    }
}