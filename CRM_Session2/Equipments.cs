//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Session2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipments()
        {
            this.EquipmentInstallations = new HashSet<EquipmentInstallations>();
        }
    
        public int EquiomentID { get; set; }
        public string EquiomentName { get; set; }
        public int TypeEquipmentID { get; set; }
        public string InvertaryNumberOS { get; set; }
        public string MACAdress { get; set; }
        public string SerialNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentInstallations> EquipmentInstallations { get; set; }
        public virtual TypeEquioment TypeEquioment { get; set; }
    }
}
