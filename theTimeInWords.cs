public static string timeInWords(int h, int m)
    {
        string text;
        if(m == 15 || m == 30){ 
         return $"{WriteWord(m)} past {WriteWord(h)}";
        }else if(m == 45){
            return $"quarter to {WriteWord(h + 1)}"; 
        }else if( m == 00){
             return $"{WriteWord(h)} o' clock"; 
        }else if (m < 30){
            text = m == 1 ? "minute" : "minutes";
            return $"{WriteWord(m)} {text} past {WriteWord(h)}";
        }
        else{
            m = 60 - m;
            text = m == 1 ? "minute" : "minutes";
             return $"{WriteWord(m)} {text} to {WriteWord(h+1)}";  
        }
    }
        static string WriteWord(int number){
          switch(number){
           case 1: return "one"; 
           case 2: return "two";
           case 3: return "three";
           case 4: return "four";
           case 5: return "five";
           case 6: return "six";
           case 7: return "seven";
           case 8: return "eight";
           case 9: return "nine";
           case 10: return "ten";
           case 11: return "eleven";
           case 12: return "twelve";
           case 13: return "thirteen";
           case 14: return "fourteen";
           case 15: return "quarter";
           case 16: return "sixteen";
           case 17: return "seventeen";
           case 18: return "eighteen";
           case 19: return "nineteen";
           case 20: return "twenty";
           case 21: return "twenty one";
           case 22: return "twenty two";
           case 23: return "twenty three";
           case 24: return "twenty four";
           case 25: return "twenty five";
           case 26: return "twenty six";
           case 27: return "twenty seven";
           case 28: return "twenty eight";
           case 29: return "twenty nine";
           case 30: return "half";
           default: return "";
        }  
       }
