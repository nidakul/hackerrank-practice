static string catAndMouse(int x, int y, int z) {
        int a = Math.Abs(z - x);
        int b = Math.Abs(z - y);
        if(a < b){
            return "Cat A";
        }else if(a == b){
            return "Mouse C";
        }else{
            return "Cat B";
        }
}
