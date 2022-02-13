using System.ComponentModel.DataAnnotations.Schema;

namespace HrPtoManagement.Web.Data
{
    public class PtoAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("PtoTypeId")]
        public PtoType PtoType { get; set; }
        public int PtoTypeId { get; set; }

        public string EmployeeId { get; set; }
    }
}
