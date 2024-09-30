 public static void plusMinus(List<int> arr)
    {
        double negative = 0;
        double positive = 0;
        double notr = 0;
        foreach(int num in arr){
            if(num > 0){
                positive++;
            }else if(num < 0){
                negative++;
            }else{
                notr++;
            }
        }
        Console.WriteLine((positive / arr.Count).ToString("F6"));
        Console.WriteLine((negative / arr.Count).ToString("F6"));
        Console.WriteLine((notr / arr.Count).ToString("F6"));
    }
