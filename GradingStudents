 public static List<int> gradingStudents(List<int> grades)
    {
        int temp = 0;
        for(int i = 0; i<grades.Count; i++){
             if((grades[i] % 5 != 0)){
               temp = grades[i];
               do{
                   temp++;
               }while(temp % 5 != 0);
               if(temp >= 40){
                    int result = temp - grades[i];
               if(result < 3){
               grades[i] = temp;
           }
               }
              
        }
        }
        return grades;
        }
