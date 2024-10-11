 public static void bonAppetit(List<int> bill, int k, int b)
    {
        int sum = 0;
        foreach(int n in bill){
            sum += n;
        }
        int result = (sum - bill[k]) / 2;
        if(b == result){
            Console.WriteLine("Bon Appetit");
        }else{
            Console.WriteLine(b  - result);
        }
    }
