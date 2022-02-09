

using System;

using System.Collections;

namespace Task_2_1;

public class Task_2_1_2
{

    public static void Main(string[] arg)
    {

        //Напишите класс, задающий круг с указанными координатами центра, радиусом, а также 
        //свойствами, позволяющими узнать длину описанной окружности и площадь круга. 
        //Кроме этого, создайте класс, описывающий кольцо, заданное координатами центра, внешним и 
        //внутренним радиусами, а также свойствами, позволяющими узнать площадь кольца и суммарную 
        //длину внешней и внутренней окружностей.
        //Подумайте над взаимосвязью этих сущностей, возможной иерархией. Задача – максимально 
        //сократить повтор кода в рамках задания.
        //По аналогии опишите классы других фигур. На их основе реализуйте собственный графический 
        //редактор, который взаимодействует с кольцами, окружностями, кругами, прямоугольниками,
        //квадратами, треугольниками и линиями.
        //Пользователю доступны следующие действия:
        //-добавить фигуру(предварительно введя её характеристики)
        //- вывести все фигуры на экран (вывести список фигур и их характеристик)
        //-очистить холст(удалить все фигуры)
        //Требование корректности характеристик фигур на каждом этапе неизменно, помните об этом!
        //Вариант со * - добавьте к приложению пользователей. Например, пользователь может вначале 
        //вводить имя, приложение, запрашивая действие, обращается по этому имени. Кроме опции 
        //«ВЫХОД» появляется опция «СМЕНИТЬ ПОЛЬЗОВАТЕЛЯ», требующая заново ввести имя.
        //    ВЫВОД: Выберите действие
        //1.Добавить фигуру
        //2.Вывести фигуры
        //3.Очистить холст
        //4.Выход
        //ВВОД: 1
        //ВЫВОД: Выберите тип фигуры:
        //…
        //ВВОД: 1
        //ВЫВОД: Введите параметры фигуры Круг
        //ВЫВОД: Введите координаты центра
        //ВВОД: …
        //ВЫВОД: Введите радиус
        //ВВОД: …
        //ВЫВОД: Фигура Круг создана!
        //ВЫВОД: Выберите действие

        Stack Canvas = new Stack();

        Console.WriteLine("Введите имя пользователя: ");
        ;
        User LoggedInUser = Login(Console.ReadLine());

        DrawInterface(ref LoggedInUser, ref Canvas);

    }

    public static User Login(string userName)
    {
        return new User(userName);
    }



    public static void DrawInterface(ref User LoggedInUser, ref Stack Canvas)
    {

        switch (DrawAndGetIntTopMenu(ref LoggedInUser))
        {
            case 1:
                switch (DrawAndGetIntFigureMenu())
                {
                    case 1:

                        Console.WriteLine("Введите параметры линии:");
                        int startX, startY;
                        int endX, endY;
                        int centerLineX, centerLineY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerLineX);
                        int.TryParse(Console.ReadLine(), out centerLineY);
                        Console.WriteLine("Введите координаты начала линии:");
                        int.TryParse(Console.ReadLine(), out startX);
                        int.TryParse(Console.ReadLine(), out startY);
                        int.TryParse(Console.ReadLine(), out endX);
                        int.TryParse(Console.ReadLine(), out endY);
                        Line NewLine = new Line(centerLineX, centerLineY, startX, startY, endX, endY);
                        Console.WriteLine($"Линия создана!" + Environment.NewLine + NewLine.ToString());
                        Canvas.Push(NewLine);
                        break;

                    case 2:

                        Console.WriteLine("Введите параметры треугольника:");
                        int sideA, sideB, sideC;
                        int centerTriangX, centerTriangY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerTriangX);
                        int.TryParse(Console.ReadLine(), out centerTriangY);
                        Console.WriteLine("Введите длины сторон:");
                        int.TryParse(Console.ReadLine(), out sideA);
                        int.TryParse(Console.ReadLine(), out sideB);
                        int.TryParse(Console.ReadLine(), out sideC);
                        Triangle NewTriangle = new Triangle(centerTriangX, centerTriangY, sideA, sideB, sideC);
                        Console.WriteLine($"Треугольник создан!" + Environment.NewLine + NewTriangle.ToString());
                        Canvas.Push(NewTriangle);
                        break;
                    case 3:
                        Console.WriteLine("Введите параметры прямоугольника:");
                        int height, width;
                        int centerRectX, centerRectY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerRectX);
                        int.TryParse(Console.ReadLine(), out centerRectY);
                        Console.WriteLine("Введите длины сторон:");
                        int.TryParse(Console.ReadLine(), out height);
                        int.TryParse(Console.ReadLine(), out width);
                        Rectangle NewRectangle = new Rectangle(centerRectX, centerRectY, height, width);
                        Console.WriteLine($"Прямоугольник создан!" + Environment.NewLine + NewRectangle.ToString());
                        Canvas.Push(NewRectangle);
                        break;
                    case 4:
                        Console.WriteLine("Введите параметры квадрата:");
                        int side;
                        int centerSqreX, centerSqreY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerSqreX);
                        int.TryParse(Console.ReadLine(), out centerSqreY);
                        Console.WriteLine("Введите длину стороны:");
                        int.TryParse(Console.ReadLine(), out side);
                        Square NewSquare = new Square(centerSqreX, centerSqreY, side);
                        Console.WriteLine($"Квадрат создан!" + Environment.NewLine + NewSquare.ToString());
                        Canvas.Push(NewSquare);
                        break;
                    case 5:
                        Console.WriteLine("Введите параметры круга:");
                        int radiusDisc;
                        int centerDiscX, centerDiscY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerDiscX);
                        int.TryParse(Console.ReadLine(), out centerDiscY);
                        Console.WriteLine("Введите радиус:");
                        int.TryParse(Console.ReadLine(), out radiusDisc);
                        Disc NewDisk = new Disc(centerDiscX, centerDiscY, radiusDisc);
                        Console.WriteLine($"Круг создан!" + Environment.NewLine + NewDisk.ToString());
                        Canvas.Push(NewDisk);
                        break;
                    case 6:
                        Console.WriteLine("Введите параметры окружности:");
                        int radiusCircle;
                        int centerCircleX, centerCircleY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerCircleX);
                        int.TryParse(Console.ReadLine(), out centerCircleY);
                        Console.WriteLine("Введите радиус:");
                        int.TryParse(Console.ReadLine(), out radiusCircle);
                        Circle NewCircle = new Circle(centerCircleX, centerCircleY, radiusCircle);
                        Console.WriteLine($"Окружность создана!" + Environment.NewLine + NewCircle.ToString());
                        Canvas.Push(NewCircle);
                        break;
                    case 7:
                        Console.WriteLine("Введите параметры кольца:");
                        int radiusRing, innerRadiusRing;
                        int centerRingX, centerRingY;
                        Console.WriteLine("Введите координаты центра:");
                        int.TryParse(Console.ReadLine(), out centerRingX);
                        int.TryParse(Console.ReadLine(), out centerRingY);
                        Console.WriteLine("Введите внешний радиус:");
                        int.TryParse(Console.ReadLine(), out radiusRing);
                        Console.WriteLine("Введите внутренний радиус:");
                        innerRadiusRing = int.Parse(Console.ReadLine());
                        Ring NewRing = new Ring(centerRingX, centerRingY, radiusRing, innerRadiusRing);
                        Console.WriteLine($"Кольцо создано!" + Environment.NewLine + NewRing.ToString());
                        Canvas.Push(NewRing);
                        break;

                }
                DrawInterface(ref LoggedInUser, ref Canvas);
                break;
            case 2:
                {
                    foreach (Object obj in Canvas)
                    {
                        Console.WriteLine(obj);
                    }
                }
                DrawInterface(ref LoggedInUser, ref Canvas);
                break;
            case 3:
                Canvas.Clear();
                DrawInterface(ref LoggedInUser, ref Canvas);
                break;
            case 4:
                Canvas.Clear();
                Console.WriteLine("Введите имя пользователя: ");
                ;
                LoggedInUser = Login(Console.ReadLine());
                DrawInterface(ref LoggedInUser, ref Canvas);
                break;
            case 5:
                Console.WriteLine("Выходим ");
                break;

            default:
                break;
        }
    }


    public static int DrawAndGetIntTopMenu(ref User LoggedInUser)
    {
        Console.WriteLine($"Выберите действие,{LoggedInUser.UserName} " + Environment.NewLine +
                           "1.Добавить фигуру" + Environment.NewLine +
                           "2.Вывести фигуры" + Environment.NewLine +
                           "3.Очистить холст" + Environment.NewLine +
                           "4.Сменить пользователя" + Environment.NewLine +
                           "5.Выход");
        if (int.TryParse(Console.ReadLine(), out int actionNumber))
        {
            return actionNumber;
        }
        else
        {
            Console.WriteLine("Error input");
            return -1;
        }
    }

    public static int DrawAndGetIntFigureMenu()
    {
        Console.WriteLine("Выберите тип фигуры" + Environment.NewLine +
                          "1.Линия" + Environment.NewLine +
                          "2.Треугольник" + Environment.NewLine +
                          "3.Прямоугольник" + Environment.NewLine +
                          "4.Квадрат" + Environment.NewLine +
                          "5.Круг" + Environment.NewLine +
                          "6.Окружность" + Environment.NewLine +
                          "7.Кольцо");
        if (int.TryParse(Console.ReadLine(), out int actionNumber))
        {
            return actionNumber;
        }
        else
        {
            Console.WriteLine("Error input");
            return -1;
        }

    }


}

