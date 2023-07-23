using Mindbox.IntroductoryTask.Library;
using Xunit;

namespace Mindbox.IntroductoryTask.UnitTests;

public class TriangleTests
{
    [Fact]
    public void TriangleArea_ShouldBeCorrect()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.GetArea(), 2);
    }

    [Fact]
    public void Triangle_ShouldBeRight()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void Triangle_ShouldNotBeRight()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightTriangle());
    }
    
    [Fact]
    public void Triangle_ShouldThrowException_WhenAnySideIsNonPositive()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 0));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
    }

    [Fact]
    public void Triangle_ShouldThrowException_WhenSidesDoNotFormTriangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 1, 2));
        Assert.Throws<ArgumentException>(() => new Triangle(2, 3, 1));
    }
}