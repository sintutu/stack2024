using FluentAssertions;
using skills.models;
using stack2024.Pages;

namespace unit.tests;

[TestFixture]
public class OverviewPageTests
{
    [Test]
    public void OnGet_WithData_ReturnsPage()
    {
        // Arrange
        var model = new OverviewModel();
        var dummyData = new List<Requirement>
        {
            new Requirement
            {
                Title = "Requirement 1",
                TestScenarios = new List<Scenario>
                {
                    new Scenario
                    {
                        Title = "Scenario 1.1",
                        TestCases = new List<TestCase>
                        {
                            new TestCase { Title = "Test Case 1.1.1" },
                            new TestCase { Title = "Test Case 1.1.2" }
                        }
                    },
                    new Scenario
                    {
                        Title = "Scenario 1.2",
                        TestCases = new List<TestCase>
                        {
                            new TestCase { Title = "Test Case 1.2.1" },
                            new TestCase { Title = "Test Case 1.2.2" }
                        }
                    }
                }
            },
            new Requirement
            {
                Title = "Requirement 2",
                TestScenarios = new List<Scenario>
                {
                    new Scenario
                    {
                        Title = "Scenario 2.1",
                        TestCases = new List<TestCase>
                        {
                            new TestCase { Title = "Test Case 2.1.1" },
                            new TestCase { Title = "Test Case 2.1.2" }
                        }
                    },
                    new Scenario
                    {
                        Title = "Scenario 2.2",
                        TestCases = new List<TestCase>
                        {
                            new TestCase { Title = "Test Case 2.2.1" },
                            new TestCase { Title = "Test Case 2.2.2" }
                        }
                    }
                }
            }
        };
        model.Requirements = dummyData;

        // Act
        model.OnGet();

        // Assert
        model.Page().Should().NotBeNull();
    }
}

