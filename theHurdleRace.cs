 public static int hurdleRace(int k, List<int> height)
    {
        int result = 0, temp = height[0];
        for(int i = 1; i<height.Count; i++){
            if(temp < height[i]){
            temp = height[i];
        }
        if(k<temp){
            result = temp - k;
        }
        }
        return result;
    
    }
