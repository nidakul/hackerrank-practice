 public static int diagonalDifference(List<List<int>> arr)
    {
       int firstSum = 0, secondSum=0;
        for(int i = 0; i<arr.Count; i++){
            firstSum += arr[i][i];
            secondSum += arr[i][arr.Count-1-i];
        }
        return Math.Abs(firstSum - secondSum);
    }
}
