 public static long strangeCounter(long t)
    {
    long startValue = 3;
    long startTime = 1;
    while(t >= startValue + startTime){
        startTime += startValue;
        startValue *=2;
    }
        return startValue - (t - startTime);
    }
}
