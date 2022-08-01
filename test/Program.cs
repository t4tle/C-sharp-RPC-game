using System;
using System.Collections.Generic;

public class Test{

    public static int findMinToll(int N,int[] A){
        //this is default OUTPUT. You can change it.
        int result = -404;
        //write your Logic here:
        int tot = 0;
        int num = 0;
        int len = A.Count();
        for(int i = 1; i < N; i++){
            tot += Math.Abs(A[i] - A[i+1]);

            }
        
        
        return tot;
    }
    


    // INPUT [uncomment & modify if required]
    public static void Main(){
        string line = "All the Best!";
        List<string> temp = new List<string> { };
        
        while ( ! string .IsNullOrEmpty (line)){
            line = Console.ReadLine();
            //Console.WriteLine(line);

            if (line!=null){
                string[] elements = line.Split(' ');
                
                foreach (string element in elements)
                {
                    temp.Add(element);
                }

            }
        }

        int N = Convert.ToInt32(temp[0]);
		int[] A = new int[N];
		for(int i = 1; i < 1+N; i++) {
			A[i-(1)] = Convert.ToInt32(temp[i]);
		}
		
        //Console.WriteLine(N.ToString());
        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(findMinToll(N,A));
    }

}