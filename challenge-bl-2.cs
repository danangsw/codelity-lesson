using System;
					
public class Program
{
	public static void Main()
	{
		int max = 0;
		int[] arr = {1,2,2,1,1,1,1,5,6,6,5,6,7};
		// int[] arr = {0,1};
		for (int i = 0; i < arr.Length - 1; i++)
        {
          for (int j = i + 1; j < arr.Length; j++)
		  {
			  int val = biValue(i,j,arr);
			  if(val > max) max = val; 
		  }
		}
		
		Console.WriteLine("-----");
		Console.WriteLine(max);
	}
	
	private static int biValue(int k, int j, int[] A) {
		int size = 0;
		int[] A2 = new int[j-k+1];
		
		int y = 0;
		for(int i=k; i<=j; i++) {
			A2[y]=A[i];
			// Console.WriteLine("{0} {1}",A2[y], A[i]);
			y++;
		}
		
		Console.WriteLine("-----");
		
		Array.Sort(A2);
		
		int limit = 0;
		for(int i = 0; i<A2.Length-1; i++) {
			
			if ((A2[i] ^ A2[i+1]) != 0) {
				limit++;
			}
			
			if(limit > 1) break;
			
			size++;
			
			Console.WriteLine("{0} {1} {2}",A2[i],A2[i+1],size);
		}
		
		return size; 
	}
}
