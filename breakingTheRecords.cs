 public static List<int> breakingRecords(List<int> scores)
    {
        int lowest = 0, lowestTemp = scores[0];
        int highest = 0, highestTemp = scores[0];
        for(int i = 1; i<scores.Count; i++){
           
            if(lowestTemp > scores[i]){
                lowestTemp = scores[i];
                lowest++;
            }else if(highestTemp < scores[i]){
                highestTemp = scores[i];
                highest++; 
            }
        }
         List<int> result = new List<int> { highest, lowest };
        return result;
    }
