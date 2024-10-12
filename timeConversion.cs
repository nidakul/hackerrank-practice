 public static string timeConversion(string s)
    {
        int number = int.Parse(s.Substring(0,2));
        if(s.EndsWith("PM") && number != 12){
            number += 12;
        }
        else if(s.EndsWith("AM") && number == 12){
            number = 00;
        }       
        return  number.ToString("D2") + s.Substring(2,6);
    }
