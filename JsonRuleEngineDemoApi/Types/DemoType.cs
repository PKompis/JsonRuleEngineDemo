using System;

namespace JsonRuleEngineDemoApi.Types
{
    /// <summary>
    /// Demo class
    /// </summary>
    public class DemoType
    {
        /// <summary>
        /// Gets or sets the demo string.
        /// </summary>
        /// <example>Test1</example>
        /// <value>
        /// The demo string.
        /// </value>
        public string DemoString { get; set; }

        /// <summary>
        /// Gets or sets the demo int.
        /// </summary>
        /// <example>2</example>
        /// <value>
        /// The demo int.
        /// </value>
        public int DemoInt { get; set; }

        /// <summary>
        /// Gets or sets the demo date time.
        /// </summary>
        /// <example>2021-04-04T17:23:01.049Z</example>
        /// <value>
        /// The demo date time.
        /// </value>
        public DateTime DemoDateTime { get; set; }

        /// <summary>
        /// Gets or sets the demo decimal.
        /// </summary>
        /// <example>2.0</example>
        /// <value>
        /// The demo decimal.
        /// </value>
        public decimal DemoDecimal { get; set; }

        /// <summary>
        /// Gets or sets the demo nullable decimal.
        /// </summary>
        /// <example>2.0</example>
        /// <value>
        /// The demo nullable decimal.
        /// </value>
        public decimal? DemoNullableDecimal { get; set; }

        /// <summary>
        /// Gets or sets the demo unique identifier.
        /// </summary>
        /// <example>fa03ab21-a3ff-40d9-b216-2906de7d1307</example>
        /// <value>
        /// The demo unique identifier.
        /// </value>
        public Guid DemoGuid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [demo bool].
        /// </summary>
        /// <example>false</example>
        /// <value>
        ///   <c>true</c> if [demo bool]; otherwise, <c>false</c>.
        /// </value>
        public bool DemoBool { get; set; }
    }
}
