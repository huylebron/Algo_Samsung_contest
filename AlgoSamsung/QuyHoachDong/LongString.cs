namespace AlgoSamsung.QuyHoachDong ;

public class LongString
{
    // Bài 2: Tìm dãy con chung dài nhất (LCS)
    
    
    public static int SolveLCS(int[] A, int[] B)
    {
        int m = A.Length;
        int n = B.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Khởi tạo mảng dp
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (A[i - 1] == B[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[m, n];
    }
    
    public static void TestSolution()
    {
        int[] A = { 1, 2, 3, 4, 1 };
        int[] B = { 3, 4, 1, 2, 1, 3 };
     
        Console.WriteLine($"Dãy con chung dài nhất: {SolveLCS(A, B)}");
    }
    
    public static void Main1(string[] args)
    {  
        TestSolution();
        Console . ReadKey ( ) ;
    }
    
    
    
}