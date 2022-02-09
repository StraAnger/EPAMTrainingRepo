using System;
using System.Text;

namespace Task_2_1;

public class Task_2_1_1
{

    public static void Main(string[] arg)
    {

        //Создайте иерархию классов и пропишите ключевые методы для компьютерной игры (без 
        //реализации функционала). Суть игры:
        //• Игрок может передвигаться по прямоугольному полю размером Width на Height;
        //• На поле располагаются бонусы (яблоко, вишня и т.д.), которые игрок может подобрать для 
        //поднятия каких-либо характеристик;
        //• За игроком охотятся монстры (волки, медведи и т.д.), которые могут передвигаться по
        //карте по какому-либо алгоритму;
        //• На поле располагаются препятствия разных типов (камни, деревья и т.д.), которые игрок и 
        //монстры должны обходить.
        //Цель игры — собрать все бонусы и не быть «съеденным» монстрами.
        //При желании объекты-бонусы могут быть заменены вами на аналогичные (патроны, канистры с 
        //бензином, монетки), также, как и враги (роботы, мумии, зомби). Включайте фантазию!
        //Вариант со * - подумайте над реализацией консольного геймплея вашей игры. Как он может 
        //выглядеть? Каким образом отрисовать поле? Добавьте классы визуализации поля, препятствий,
        //врагов и бонусов на нём.
        //Вариант с ** - попробуйте сделать играбельную версию вашего проекта. На данном этапе не 
        //стоит заморачиваться над балансом, интересностью геймплея или удобством

        do
        {
            Console.Clear();
            Console.WriteLine("The PlaneScape Game" + Environment.NewLine + "Press Enter to START");

        }
        while (Console.ReadKey().Key != ConsoleKey.Enter);
        MainGameCycle();



    }

    public static void MainGameCycle()
    {
        // Press Escape to exit if you dare =)
        bool exitFlag = false;
        bool gameOverFlag = false;
        Random rndEnemy = new Random();
        Random rndPlayer = new Random();
        Random rndSolidObjects = new Random();
        const int HEIGHT = 10;
        const int WIDTH = 10;
        GameField MainField = InitGameField(HEIGHT, WIDTH);
        SolidObjects FirstSolidObject = InitSolidObjects(rndSolidObjects.Next(0, 10), rndSolidObjects.Next(0, 10));
        Player MainPlayer = InitPlayer(rndPlayer.Next(0, 10), rndPlayer.Next(0, 10));
        Enemy FirstEnemy = InitEnemy(rndEnemy.Next(0,10), rndEnemy.Next(0, 10));

        do
        {
            Console.Clear();
            FillGameField(ref MainField, ref MainPlayer, ref FirstEnemy,ref FirstSolidObject);
            OutputGameField(ref MainField);
            exitFlag = MoveCharactersOnGameField(ref MainPlayer, ref FirstEnemy,ref FirstSolidObject, HEIGHT, WIDTH);
            gameOverFlag = IsPlayerDead(ref MainPlayer, ref FirstEnemy);

        }
        while (!exitFlag&&!gameOverFlag);

        if (exitFlag)
        {
            Console.Clear();
            Console.WriteLine("Waiting you back!");
        }
        if (gameOverFlag)
        {
            Console.Clear();
            Console.WriteLine("You LOST!!!");
        }
    }

    public static GameField InitGameField(int height, int width)
    {
        // Create game field

        return new GameField(height, width);
    }

    public static SolidObjects InitSolidObjects(int CoordinateX, int CoordinateY)
    {
        // Create game field

        return new SolidObjects(CoordinateX, CoordinateY);
    }

    public static Player InitPlayer(int CoordinateX, int CoordinateY)
    {
        // Create Player

        return new Player(CoordinateX, CoordinateY);
    }

    public static Enemy InitEnemy(int CoordinateX,int CoordinateY)
    {
        // Create Enemy

        return new Enemy(CoordinateX,CoordinateY);
    }


    public static void CalculateGameField(ref GameField MainGameField)
    {
        // Calculate all positions on GameField object




    }

    public static bool IsPlayerDead(ref Player inputPlayer,ref Enemy inputEnemy)
    {
        if(inputPlayer.CoordinateX==inputEnemy.CoordinateX|| inputPlayer.CoordinateY == inputEnemy.CoordinateY)
        {
            return true;
        }

        return false;
    }

    public static bool MoveCharactersOnGameField(ref Player InputPlayer, ref Enemy InputEnemy,ref SolidObjects InputSolidObject, int height, int width)
    {

        // Calculate coordinates of Player and Enemies after movement
        if (MovePlayer(ref InputPlayer,ref InputSolidObject, height, width) == -1) return true;
        MoveEnemy(ref InputPlayer, ref InputEnemy, height, width);
        return false;
    }

    public static int MovePlayer(ref Player inputPlayer,ref SolidObjects inputSolidObject, int height, int width)
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.RightArrow:
                {
                    if (inputPlayer.CoordinateY < height - 1&& inputPlayer.CoordinateY!=inputSolidObject.CoordinateY)
                        ++inputPlayer.CoordinateY;
                    return 0;

                }
            case ConsoleKey.LeftArrow:
                {
                    if (inputPlayer.CoordinateY > 0 && inputPlayer.CoordinateY != inputSolidObject.CoordinateY)
                        --inputPlayer.CoordinateY;
                    return 0;

                }
            case ConsoleKey.UpArrow:
                {
                    if (inputPlayer.CoordinateX > 0 && inputPlayer.CoordinateX != inputSolidObject.CoordinateX)
                        --inputPlayer.CoordinateX;
                    return 0;

                }
            case ConsoleKey.DownArrow:
                {
                    if (inputPlayer.CoordinateX < width - 1 && inputPlayer.CoordinateX != inputSolidObject.CoordinateX)
                        ++inputPlayer.CoordinateX;
                    return 0;

                }
            case ConsoleKey.Escape:
                {
                    return -1;

                }
            default:
                return 0;
        }
    }

    public static void MoveEnemy(ref Player inputPlayer, ref Enemy inputEnemy, int height, int width)
    {



        if (inputEnemy.CoordinateY > 0 && inputEnemy.CoordinateY < height - 1)
        {
            if (inputEnemy.CoordinateY > inputPlayer.CoordinateY)
                --inputEnemy.CoordinateY;
            if (inputEnemy.CoordinateY < inputPlayer.CoordinateY)
                ++inputEnemy.CoordinateY;
        }

        if (inputEnemy.CoordinateX > 0 && inputEnemy.CoordinateX < width - 1)
        {
            if (inputEnemy.CoordinateX > inputPlayer.CoordinateX)
                --inputEnemy.CoordinateX;
            if (inputEnemy.CoordinateX < inputPlayer.CoordinateX)
                ++inputEnemy.CoordinateX;
        }

    }

    public static void FillGameField(ref GameField InputGameField, ref Player InputPlayer, ref Enemy InputEnemy,ref SolidObjects InputSolidObject)
    {
        // Put Objects and Characters in MainFieldMatrix

        for (int i = 0; i < InputGameField.Height; ++i)
        {
            for (int j = 0; j < InputGameField.Width; ++j)
            {
                InputGameField.GameFieldMatrix[i, j] = '.';
            }
        }

        InputGameField.GameFieldMatrix[InputPlayer.CoordinateX, InputPlayer.CoordinateY] = 'P';
        InputGameField.GameFieldMatrix[InputEnemy.CoordinateX, InputEnemy.CoordinateY] = 'E';
        InputGameField.GameFieldMatrix[InputSolidObject.CoordinateX, InputSolidObject.CoordinateY] = 'O';

    }

    public static void OutputGameField(ref GameField InputGameField)
    {
        // Output MainFieldMatrix

        for (int i = 0; i < InputGameField.Height; ++i)
        {
            for (int j = 0; j < InputGameField.Width; ++j)
            {
                Console.Write(InputGameField.GameFieldMatrix[i, j]);
            }
            Console.Write(Environment.NewLine);
        }
    }
}




