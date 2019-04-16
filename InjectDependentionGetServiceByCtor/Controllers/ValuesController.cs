using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace InjectDependentionGetServiceByCtor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IContainer container;

        public ValuesController(IContainer container)
        {
            this.container = container;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            ITimes time1 = container.ResolveNamed<ITimes>("SaoBento");
            ITimes time2 = container.ResolveNamed<ITimes>("Corinthians");

            return new string[] { time1.Time, time2.Time};
        }
       
    }
}
