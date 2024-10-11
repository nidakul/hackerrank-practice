 public static void miniMaxSum(List<int> arr)
    {
        arr = arr.OrderBy(n => n).ToList();
        long minSum = 0, maxSum=0;
        for(int i = 0; i<arr.Count - 1; i++){
            minSum += arr[i];
        }
        for(int j=1 ; j<arr.Count; j++)
        {
            maxSum += arr[j];
        }
        Console.WriteLine(minSum + " " + maxSum);
    }
