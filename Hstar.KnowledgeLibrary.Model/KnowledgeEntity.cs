using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hstar.KnowledgeLibrary.Model
{
    [Table("Biz_Knowledge")]
    public class KnowledgeEntity : BaseEntity
    {
        [Key]
        public int KnowledgeId { get; set; }

        public string KnowledgeType { get; set; }

        public string Tags { get; set; }

        public string KnowledgeSubject { get; set; }

        public string KnowledgeContent { get; set; }

    }
}
