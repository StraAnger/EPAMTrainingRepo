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


    public string StringOutput()
    {
        string output = new string(StringOfChar);

        return output;
    }

    public bool IsEqual(CharString inputString)
    {

        if (StringOfChar.Length == inputString.StringOfChar.Length)
        {
            for (int i = 0; i < StringOfChar.Length; ++i)
            {
                if (StringOfChar[i] != inputString.StringOfChar[i])
                    return false;
            }
            return true;
        }

        return false;
    }

    public int IndexOfChar(char inputCharacter)
    {
        for (int i = 0; i < StringOfChar.Length; ++i)
        {
            if (StringOfChar[i] == inputCharacter)
                return i;
        }
        return -1;
    }

    public int LengthOfString()
    {
        int counter = 0;
        for (int i = 0; i < StringOfChar.Length; ++i)
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
        for (int i = 0; i < StringOfChar.Length; ++i)
        {
            if (StringOfChar[i] == ' ')
                ++counter;
        }
        if (counter != 0) return counter;
        else
        {
          return -1;
        }
    }
}