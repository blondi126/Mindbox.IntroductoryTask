using Mindbox.IntroductoryTask.Library;

// Создание новых экземпляров фигур с валидными значениями
var circle = new Circle(10);
var triangle = new Triangle(3, 4, 5);
var rectangle = new Rectangle(4, 5);

// Вычисление и вывод площадей
Console.WriteLine("The circle area is " + GetArea(circle));
Console.WriteLine("The triangle area is " + GetArea(triangle));
Console.WriteLine("The rectangle area is " + GetArea(rectangle));

// Проверка, является ли треугольник прямоугольным
Console.WriteLine("The triangle is right: " + triangle.IsRightTriangle());

// Попытка создать фигуры с невалидными значениями
try
{
    var invalidCircle = new Circle(-1);
}
catch (ArgumentException e)
{
    Console.WriteLine("Invalid circle: " + e.Message);
}

try
{
    var invalidTriangle = new Triangle(1, 2, 3);
}
catch (ArgumentException e)
{
    Console.WriteLine("Invalid triangle: " + e.Message);
}

// Вычисление площади фигуры без знания конкретного типа во время компиляции
static double GetArea(Shape shape){
    return shape.GetArea();
}