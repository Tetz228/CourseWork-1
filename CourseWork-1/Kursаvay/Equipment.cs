//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovay
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            this.Extradition = new HashSet<Extradition>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdTypeName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int IdStorage { get; set; }
    
        public virtual Storages Storages { get; set; }
        public virtual TypeEquipment TypeEquipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Extradition> Extradition { get; set; }
    }
}
