//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Borrows = new HashSet<Borrow>();
            this.Ratings = new HashSet<Rating>();
            this.WaitingLists = new HashSet<WaitingList>();
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public Nullable<int> AgeLimit { get; set; }
        public string Genre { get; set; }
        public Nullable<bool> IsBorrowable { get; set; }
        public Nullable<bool> IsBuyable { get; set; }
        public decimal BorrowPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public Nullable<decimal> PreviousPrice { get; set; }
        public Nullable<System.DateTime> DiscountEndDate { get; set; }
        public Nullable<bool> FormatEpub { get; set; }
        public Nullable<bool> FormatF2b { get; set; }
        public Nullable<bool> FormatMobi { get; set; }
        public Nullable<bool> FormatPDF { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> AvailableCopies { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow> Borrows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
