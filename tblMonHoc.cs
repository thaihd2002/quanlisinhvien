//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVienCshape
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMonHoc()
        {
            this.tblLopHocPhan = new HashSet<tblLopHocPhan>();
        }
    
        public Nullable<System.DateTime> ngaytao { get; set; }
        public string nguoitao { get; set; }
        public Nullable<System.DateTime> ngaycapnhat { get; set; }
        public string nguoicapnhat { get; set; }
        public string mamonhoc { get; set; }
        public string tenmonhoc { get; set; }
        public Nullable<int> sotinchi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLopHocPhan> tblLopHocPhan { get; set; }
    }
}