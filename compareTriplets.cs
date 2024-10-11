 public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int alia = 0, bob=0;
        for(int i = 0; i<a.Count; i++){
            if(a[i] > b[i]){
                alia ++;
            }else if(a[i] < b[i]){
                bob++;
            }
        }
        return new List<int> {alia,bob};
    }
