public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount= 0, orangeCount = 0;
        for(int i = 0; i<apples.Count; i++){
            int applePosition = a + apples[i];
            if(applePosition >= s && applePosition<=t){
                appleCount++;
            }
        }
        for(int j = 0; j<oranges.Count; j++){
            int orangePosition = b + oranges[j];
            if(orangePosition >= s && orangePosition<=t){
                orangeCount++;
            }
        }
        Console.WriteLine($"{appleCount}\n{orangeCount}");
    }
