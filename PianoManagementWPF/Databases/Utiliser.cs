//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PianoManagementWPF.Databases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utiliser
    {
        public int PianoId { get; set; }
        public int ProfesseurId { get; set; }
        public string UtiliserRemarque { get; set; }
    
        public virtual Piano Piano { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
