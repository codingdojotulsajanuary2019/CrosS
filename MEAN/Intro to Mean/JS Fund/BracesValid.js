function BracesValid(string)
{
    if(string[1] == "]" || string[i] == "}" || string[i] == ")")
    {
        return false;
    }
    for(var i = 0; i < string.length; i++)
    {
        if(string[i] == "[")
        {
            for(var x = i+1; x < string.length; x++)
            {
                if(string[x] == "[")
                {
                    return false;
                }
                if(string[x] == "]")
                {
                    break;
                }
            }
        }
        if(string[i] == "(")
        {
            for(var x = i+1; x < string.length; x++)
            {
                if(string[x] == "(")
                {
                    return false;
                }
                if(string[x] == ")")
                {
                    break;
                }
            }
        }
        if(string[i] == "{")
        {
            for(var x = i+1; x < string.length; x++)
            {
                if(string[x] == "{")
                {
                    return false;
                }
                if(string[x] == "}")
                {
                    break;
                }
            }
        }
    }
    return true;
}
console.log(BracesValid("{[]}{}[][]()"));