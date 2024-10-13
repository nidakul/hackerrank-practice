 public static string angryProfessor(int k, List<int> a)
    {
        int count = 0;
        foreach(int i in a){
            if(i <= 0){
                count++;
            }
        }
        if(count >= k){
            return "NO";
        }else{return "YES";}
    }

// int count = a.Count(i => i <= 0);
//   return count >= k ? "NO" : "YES";
