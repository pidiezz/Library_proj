//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_proj
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccSet
    {
        public int idClient { get; set; }
        public int idEmp { get; set; }
        public int idBook { get; set; }
        public int id { get; set; }
    
        public virtual BookSet BookSet { get; set; }
        public virtual ClientSet ClientSet { get; set; }
        public virtual EmpSet EmpSet { get; set; }
    }
}
