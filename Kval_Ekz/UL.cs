//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kval_Ekz
{
    using System;
    using System.Collections.Generic;
    
    public partial class UL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public Nullable<int> Id_manager { get; set; }
    
        public virtual Managers Managers { get; set; }
    }
}
