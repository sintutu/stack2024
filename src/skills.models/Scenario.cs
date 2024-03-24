namespace skills.models;

/// <summary>
/// Represents a test scenario associated with a requirement.
/// </summary>
public class Scenario
{
    /// <summary>
    /// Gets or sets the title of the scenario.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the list of test cases associated with the scenario.
    /// </summary>
    public List<TestCase> TestCases { get; set; }
}
