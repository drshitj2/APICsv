using Sample.Models;
using System;
using System.Web.Http;

namespace Sample.Controllers
{
    [Route("{id}")]
    public class ValuesController : ApiController
    {
        // GET /5
        [HttpGet]
        public Object Get(string id)
        {
            try
            {
                if (Start.resourceList.ContainsKey(id))
                {
                    KeyValue result = new KeyValue();
                    result.Key = id;
                    result.Value = Convert.ToInt32(Start.resourceList[id]);
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new { error = "An error occurred while fetching the value. Please try again" };
            }
            return new { error = "No such key Exist" };
        }
    }
}
