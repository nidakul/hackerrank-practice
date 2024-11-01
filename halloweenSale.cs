  public static int howManyGames(int p, int d, int m, int s) {
    int totalCost = 0; 
    int count = 0;  
    
    while (totalCost + p <= s) {  
        totalCost += p;          
        count++;                   

        if (p - d >= m) {
            p -= d;                 
        } else {
            p = m;                  
        }
    }

    return count;  
}
