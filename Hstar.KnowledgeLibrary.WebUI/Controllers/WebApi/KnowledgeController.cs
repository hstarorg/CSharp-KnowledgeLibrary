using System.Collections.Generic;
using System.Web.Http;

namespace Hstar.KnowledgeLibrary.WebUI.Controllers.WebApi
{
    public class KnowledgeController : ApiController
    {
        // GET api/test（获取列表）
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/test/5(查询单条)
        public string Get(int id)
        {
            return "value";
        }

        // POST api/test(新建)
        public void Post([FromBody]string value)
        {
        }

        // PUT api/test/5（更新）
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/test/5（删除）
        public void Delete(int id)
        {
        }
    }
}
