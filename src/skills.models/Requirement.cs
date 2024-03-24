namespace skills.models
{
    /// <summary>
    /// Represents a software requirement.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Gets or sets the title of the requirement.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the list of test scenarios associated with the requirement.
        /// </summary>
        public List<Scenario> TestScenarios { get; set; }
    }
}
