public static string kangaroo(int x1, int v1, int x2, int v2)
    {
         if(v2>v1){
             return "NO";  
     }
        for(int i = x1; i <= 100000000 ; i+=v1){
                if(i == x2){
                    return "YES";
          }
                      x2 += v2; 
        }
             return "NO";  
    }
