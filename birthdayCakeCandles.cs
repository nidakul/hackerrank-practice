public static int birthdayCakeCandles(List<int> candles)
    {
       int count = 0;
       int maxNum = candles.Max();
       for(int i = 0; i<candles.Count; i++){
           if(maxNum == candles[i]){
               count++;
           }
       }
       return count;
    }
    
    /*int max = candles.Max();
    return candles.Count(c => c == max); listedeki max değerine eşit olan mumları sayar*/
