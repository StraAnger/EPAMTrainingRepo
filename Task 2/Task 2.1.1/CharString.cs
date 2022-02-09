namespace Task_2_1;

public class CharString
{

    public char[] StringOfChar { get; set; }



    public CharString(int length)
    {
        StringOfChar = new char[length];
    }

    public CharString(char[] inputString)
    {
        StringOfChar = inputString;
    }


    public void StringOutput()
    {
        foreach (char c in StringOfChar)
            Console.Write(c);
        Console.WriteLine(Environment.NewLine);
    }

    public bool IsEqual(CharString inputString)
    {

        if (this.StringOfChar.Length == inputString.StringOfChar.Length)
        {
            for (int i = 0; i < this.StringOfChar.Length; ++i)
            {
                if (this.StringOfChar[i] != inputString.StringOfChar[i])
                    return false;
            }
            return true;
        }

        return false;
    }

    public int IndexOfChar(char inputCharacter)
    {
        for (int i = 0; i < this.StringOfChar.Length; ++i)
        {
            if (this.StringOfChar[i] == inputCharacter)
                return i;
        }
        Console.WriteLine("No such character in string");
        return -1;
    }

    public int LengthOfString()
    {
        int counter = 0;
        for (int i = 0; i < this.StringOfChar.Length; ++i)
        {
            ++counter;
        }
        return counter;
    }


    public static CharString operator +(CharString leftString, CharString rightString)
    {
        CharString NewString = new CharString(leftString.StringOfChar.Length + rightString.StringOfChar.Length);

        for (int i = 0; i < leftString.StringOfChar.Length; ++i)
        {
            NewString.StringOfChar[i] = leftString.StringOfChar[i];
        }
        for (int i = leftString.StringOfChar.Length; i < leftString.StringOfChar.Length + rightString.StringOfChar.Length; ++i)
        {
            NewString.StringOfChar[i] = rightString.StringOfChar[i - leftString.StringOfChar.Length];
        }

        return NewString;
    }

    public int CountSpaces()
    {
        int counter = 0;
        for (int i = 0; i < this.StringOfChar.Length; ++i)
        {
            if (this.StringOfChar[i] == ' ')
                ++counter;
        }
        if (counter != 0) return counter;
        else
        {
            Console.WriteLine("No spaces in string");
            return -1;
        }
    }
}