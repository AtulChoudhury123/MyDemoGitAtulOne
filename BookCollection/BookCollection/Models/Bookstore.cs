//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCollection.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookstore
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public int Pages { get; set; }
        public string Tags { get; set; }
        public Nullable<int> favourite { get; set; }

        string search;
        public string Search { get => search; set => search = value; }
    }
}
