//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatelTeaSource.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class feedback_master
    {
        public long feed_id { get; set; }
        public string email { get; set; }
        public string fname { get; set; }
        public string mob { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> cdate { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
        public string msg { get; set; }
    }
}