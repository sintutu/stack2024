using FluentAssertions;
using skills.models;

namespace unit.tests;

[TestFixture]
public class SkillsModelsTests
{
    [Test]
    public void Requirement_Title_ShouldNotBeNull()
    {
        // Arrange
        var requirement = new Requirement();

        // Act
        requirement.Title = "A requirement title";

        // Assert
        requirement.Title.Should().NotBeNull();
    }

    [Test]
    public void Requirement_TestScenarios_ShouldNotBeNull()
    {
        // Arrange, Act
        var requirement = new Requirement{
            TestScenarios = new List<Scenario>{
                new Scenario()
            }
        };

        // Assert
        requirement.TestScenarios.Should().NotBeNull();
    }

    [Test]
    public void Scenario_Title_ShouldNotBeNull()
    {
        // Arrange
        var scenario = new Scenario();

        // Act
        scenario.Title = "A scenario title";

        // Assert
        scenario.Title.Should().NotBeNull();
    }

    [Test]
    public void Scenario_TestCases_ShouldNotBeNull()
    {
        // Arrange, Act
        var scenario = new Scenario(){
            TestCases = new List<TestCase>{
                new TestCase()
            }
        };
        // Assert
        scenario.TestCases.Should().NotBeNull();
    }

    [Test]
    public void TestCase_Title_ShouldNotBeNull()
    {
        // Arrange
        var testCase = new TestCase();

        // Act
        testCase.Title = "A test case title";

        // Assert
        testCase.Title.Should().NotBeNull();
    }
}

