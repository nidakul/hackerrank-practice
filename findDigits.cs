public static int findDigits(int n) 
    {
        int count = 0;
        int temp = n ; 
        while(temp > 0){
           int d = temp % 10;
           if(d != 0 && n % d == 0)
           {
               count++;
           }
           temp /= 10;
       }
        
        return count;
    }
