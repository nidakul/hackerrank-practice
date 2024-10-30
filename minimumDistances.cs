public static int minimumDistances(List<int> a)
    {
        List<int> numbers = new List<int>();
        int difference = 0;
        for(int i = 0; i<a.Count-1; i++){
            for(int j = i+1; j<a.Count; j++){
             if(a[i] == a[j]){
              difference = Math.Abs(i - j);
              numbers.Add(difference);
            } 
        }     
        }
        return numbers.Count>0 ? numbers.Min() : -1;
}
