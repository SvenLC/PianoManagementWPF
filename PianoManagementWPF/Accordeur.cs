//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PianoManagementWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accordeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accordeur()
        {
            this.Accord = new HashSet<Accord>();
        }
    
        public int AccordeurId { get; set; }
        public string AccordeurNom { get; set; }
        public string AccordeurPrenom { get; set; }
        public int EntrepriseId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accord> Accord { get; set; }
        public virtual Entreprise Entreprise { get; set; }
    }
}