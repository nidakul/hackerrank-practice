 public static int sockMerchant(int n, List<int> ar)
    {
        int count = 0;
        ar = ar.OrderBy(a => a).ToList();
        for(int i = 0; i<n-1; i++){
            if(ar[i] == ar[i+1]){
                count++;
                i++;
            }
        }
        return count;
    }
