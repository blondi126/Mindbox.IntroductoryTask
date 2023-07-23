using Mindbox.IntroductoryTask.Library;
using Xunit;

namespace Mindbox.IntroductoryTask.UnitTests;

public class CircleTests
{
    [Fact]
    public void CircleArea_ShouldBeCorrect()
    {
        var circle = new Circle(2);
        Assert.Equal(12.57, circle.GetArea(), 2);
    }
    
    [Fact]
    public void Circle_ShouldThrowException_WhenRadiusIsNonPositive()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}