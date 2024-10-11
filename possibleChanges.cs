//Problem Solving (Basic) Certification
public static List<string> possibleChanges(List<string> usernames)
    {
        List<string> results = new List<string>(); 
        string str;
        bool foundGreater = false;
        for(int i = 0; i<usernames.Count ; i++){ 
            str = usernames[i]; 
            foundGreater = false;
            for(int j = 0; j< str.Length-1; j++){
                for(int k = j+1; k< str.Length; k++){
                    if(str[j] > str[k]){
                    results.Add("YES");
                    foundGreater = true;
                    break;
                } 
             }
             if(foundGreater){
                 break;
             }
            } 
              if(!foundGreater){ 
                     results.Add("NO"); 
                }
        }    
        return results;
    }
