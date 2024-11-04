 public static int utopianTree(int n)
    {
        int h = 0;
        for(int i = 0 ; i<=n; i++){
            h = i % 2 == 0 ? h + 1 : h * 2;
        }
        return h;
   }
