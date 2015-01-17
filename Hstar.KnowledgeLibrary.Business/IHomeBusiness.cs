using System.Collections.Generic;
using Hstar.KnowledgeLibrary.Model;

namespace Hstar.KnowledgeLibrary.Business
{
    public interface IHomeBusiness
    {
        IList<KnowledgeEntity> GetKnowledgeList(int pageIndex,string searchKey,int pageSize=20);
    }
}
