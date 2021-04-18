using JsonRuleEngineDemoApi.Types;
using RulesEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JsonRuleEngineDemoApi.Interfaces
{
    /// <summary>
    /// Demo Interface
    /// </summary>
    public interface IDemoInterface
    {
        /// <summary>
        /// Posts the simulation method.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<IEnumerable<RuleResultTree>> PostSimulationMethod(DemoType request);
    }
}
