 public static int squares(int a, int b)
    { 
        int count = 0;
        int start = (int)Math.Ceiling(Math.Sqrt(a));
        int end = (int)Math.Floor(Math.Sqrt(b));

        for (int i = start; i <= end; i++)
        {
            if (i * i >= a && i * i <= b)
            {
                count++;
            }
        }
        return count;
    }
