using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireHorizonWebApi.Controllers
{
    [Route("api/v1")]
    
    public class BaseApiController<T> : ControllerBase
    {
    }
}
