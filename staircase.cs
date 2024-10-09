public static void staircase(int n)
    {
        for(int i = 1; i<=n; i++){
            for(int j = n-1; j>= i; j--){
                Console.Write(" ");
            }
            for(int k = 1; k<=i; k++){
                Console.Write("#");
            }
        Console.WriteLine();
        }
    }
}
