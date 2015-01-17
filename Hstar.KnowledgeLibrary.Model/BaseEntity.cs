using System;

namespace Hstar.KnowledgeLibrary.Model
{
    public class BaseEntity
    {
        /// <summary>
        ///     创建时间
        /// </summary>
        public DateTime CreateOn { get; set; }

        /// <summary>
        ///     创建人
        /// </summary>
        public int CreateBy { get; set; }

        /// <summary>
        ///     最后更新时间
        /// </summary>
        public DateTime UpdateOn { get; set; }

        /// <summary>
        ///     最后更新人
        /// </summary>
        public int UpdateBy { get; set; }
    }
}