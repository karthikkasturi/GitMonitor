//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRepo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRepo()
        {
            this.tblBranches = new HashSet<tblBranch>();
        }
    
        public long tblRepoID { get; set; }
        public string Name { get; set; }
        public string RepoUrl { get; set; }
        public string WorkingDirectory { get; set; }
        public bool AutoTrack { get; set; }
        public bool EnableDesktopNotification { get; set; }
        public string NotificationEmail { get; set; }
        public string CurrentBranch { get; set; }
        public bool IsUntrackedRepo { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime ModifiedAt { get; set; }
        public Nullable<System.DateTime> RecentCheck { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBranch> tblBranches { get; set; }
    }
}
