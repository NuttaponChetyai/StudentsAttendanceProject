
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Students_Attendance_Project.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Tb_Status
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tb_Status()
    {

        this.Tb_Student = new HashSet<Tb_Student>();

        this.Tb_StudentCheck = new HashSet<Tb_StudentCheck>();

    }


    public int StatusID { get; set; }

    public string StatusName { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_Student> Tb_Student { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_StudentCheck> Tb_StudentCheck { get; set; }

}

}
