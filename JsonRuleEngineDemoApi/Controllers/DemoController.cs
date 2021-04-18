using JsonRuleEngineDemoApi.Interfaces;
using JsonRuleEngineDemoApi.Types;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonRuleEngineDemoApi.Controllers
{
    /// <summary>
    /// Demo Controller
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly IDemoInterface _demoInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoController"/> class.
        /// </summary>
        /// <param name="demoInterface">The demo interface.</param>
        public DemoController(IDemoInterface demoInterface)
        {
            _demoInterface = demoInterface;
        }

        /// <summary>
        /// Posts the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DemoType request)
        {
            var res = (await _demoInterface.PostSimulationMethod(request))?.ToList() ?? new List<RulesEngine.Models.RuleResultTree>();
            var statusCode = res.All(x => x.IsSuccess) ? 201 : 400;

            return StatusCode(statusCode, res);
        }
    }
}
