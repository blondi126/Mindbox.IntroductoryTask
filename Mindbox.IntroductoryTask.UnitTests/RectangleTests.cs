using Mindbox.IntroductoryTask.Library;
using Xunit;

namespace Mindbox.IntroductoryTask.UnitTests;

public class RectangleTests
{
    [Fact]
    public void RectangleArea_ShouldBeCorrect()
    {
        var rectangle = new Rectangle(4, 5);
        Assert.Equal(20, rectangle.GetArea(), 2);
    }

    [Fact]
    public void RectangleArea_ShouldThrowException_WhenWidthIsNonPositive()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(-1, 2));
    }

    [Fact]
    public void RectangleArea_ShouldThrowException_WhenHeightIsNonPositive()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(2, -1));
    }

    [Fact]
    public void RectangleArea_ShouldThrowException_WhenWidthAndHeightAreNonPositive()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(-1, -1));
    }
}