using JsonRuleEngineDemoApi.Interfaces;
using JsonRuleEngineDemoApi.Types;
using Newtonsoft.Json;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JsonRuleEngineDemoApi.Implementation
{
    /// <summary>
    /// Demo Implementation
    /// </summary>
    /// <seealso cref="IDemoInterface" />
    public class DemoImplementation : IDemoInterface
    {
        /// <summary>
        /// Posts the simulation method.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <exception cref="Exception">Rules not found.</exception>
        public async Task<IEnumerable<RuleResultTree>> PostSimulationMethod(DemoType request)
        {
            //TODO: Replace with storage e.g. database
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "Workflow.json", SearchOption.AllDirectories);

            if (files == null || files.Length == 0)
                throw new Exception("Rules not found.");

            var fileData = File.ReadAllText(files[0]);
            var workflowRules = JsonConvert.DeserializeObject<List<WorkflowRules>>(fileData);

            var bre = new RulesEngine.RulesEngine(workflowRules.ToArray(), null);

            return await bre.ExecuteAllRulesAsync("Demo", new[] { request });
        }
    }
}
