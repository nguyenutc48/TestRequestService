//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorMachineManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class padmc_line
    {
        public int line_id { get; set; }
        public string line_name { get; set; }
        public string line_number { get; set; }
        public string line_model { get; set; }
        public string line_process { get; set; }
        public Nullable<int> leader_id { get; set; }
        public string line_factory { get; set; }
    }
}