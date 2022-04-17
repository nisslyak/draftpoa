namespace PurchaseOrderApp.Models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public DateTime CreationDate { get; set; }
        public String Name { get; set; }
        public int TotalAmount { get; set; }
        public int UserID { get; set; }
        public Status Status { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }

    }
    public enum Status
    {
        SUBMITTED, DRAFT
    }
}