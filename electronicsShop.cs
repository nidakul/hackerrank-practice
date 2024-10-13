 static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        int maxNumber=-1;
        for(int i = 0; i<keyboards.Length; i++){
           for(int j = 0; j < drives.Length; j++){
               int sum = keyboards[i] + drives[j];
               if(sum <= b){
                   //find max number between maxNumber and sum
                   maxNumber = Math.Max(maxNumber, sum);
               }
           }
       }
        return maxNumber;
    }
