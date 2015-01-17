using System;
using System.Collections.Generic;
using System.Linq;
using Hstar.KnowledgeLibrary.DataAccess;
using Hstar.KnowledgeLibrary.Model;

namespace Hstar.KnowledgeLibrary.Business
{
    public class HomeBusiness : IHomeBusiness
    {
        private readonly IKnowledgeRepository knowledgeRepositoty;

        public HomeBusiness()
        {
            knowledgeRepositoty=new KnowledgeRepositoty();
        }
        public IList<KnowledgeEntity> GetKnowledgeList(int pageIndex, string searchKey, int pageSize = 20)
        {
            return knowledgeRepositoty.QueryList(x => x.KnowledgeId > 0).ToList();
        }
    }
}