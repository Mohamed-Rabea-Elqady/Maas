namespace Maas.Api.Entities
{
    public class TrackedEntity : BaseEntity
    {
        public string CreatedEmployeeID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedEmployeeID { get; set; }
        public string UpdatedData { get; set; }
    }
}
