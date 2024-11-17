namespace AlgoSamsung.QuyHoachDong ;

public class MaxString
{
    
    // dynamic programming
  public static int SloveDynamic ( int [ ] arr  ) {
      int n = arr.Length;
      int[] dp = new int[n];
      dp[0] = arr[0];
      int maxSum = dp[0];

      for (int i = 1; i < n; i++)
      {
          dp[i] = Math.Max(arr[i], dp[i - 1] + arr[i]);
          maxSum = Math.Max(maxSum, dp[i]);
      }

      return maxSum ; 
      

  }
  
  // btuteforce
  public static int btuteForce ( int [ ] arr ) {
      int n = arr.Length;
      int maxSum = arr[0];

      for (int i = 0; i < n; i++)
      {
          int currentSum = 0;
          for (int j = i; j < n; j++)
          {
              currentSum += arr[j];
              maxSum = Math.Max(maxSum, currentSum);
          }
      }

      return maxSum ;


  }
    
  public static void TestSolution()
  {
      int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
      Console.WriteLine($"Dãy ban đầu: [{string.Join(", ", arr)}]");
      Console.WriteLine($" Max sum dp : {SloveDynamic(arr)}");
      Console.WriteLine($"Max sum bluteforce: {btuteForce(arr)}");
  }

  
  public static void Main1(string[] args)
  {  
      TestSolution();
      Console . ReadKey ( ) ;
  }
    
    
}