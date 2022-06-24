namespace LeaveManagement.Web.Data
{
    public partial class BaseEntity
    {
        // partial means this must be ing=herited only. cannpot be instanitated.
        // this class keeps all common fields that are used by many table/class
        // So you can keep the code clean and tidy
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
