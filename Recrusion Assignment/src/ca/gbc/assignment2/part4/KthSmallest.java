package ca.gbc.assignment2.part4;

/***********************************
 * COMP2080 - Assignment 2 File name: kthsmallest.java 
 * Author: Sureya, Farah
 *  Email: sureya.farah@georgebrown.ca
 ************************************/
public class KthSmallest {

	public static final int MaxSize = 500;

	/**
	 * Return the value of the kth smallest element of array A. n is the number of
	 * elements A contains, and k <= n.
	 * 
	 * The running time of your algorithm must be O(n).
	 * 
	 * @param A
	 * @param n
	 * @param k
	 * @return
	 */
	public static int partition(int [] array, int start,int end)
			{
			int x = array[end];
			int i = start;
			for (int j = start; j <= end - 1; j++)
			{
				if (array[j] <= x) 
				{
			  
					int temp = array[i];
					array[i] = array[j];
					array[j] = temp;
			  
					i++;
				}
			}
			  

			int temp = array[i];
			array[i] = array[end];
			array[end] = temp;
			  
			return i;
			}
			  

	public static int kth_smallest(int[] array, int start, int k, int end ){
		
		if (k>0 && k <= end-start+1) {
			int position = partition(array, start,end);
			if (position - start == k-1)
				return array[position];
			if(position -start > k-1)
				return kth_smallest(array, start,k,position -1);
				return kth_smallest(array, position +1,k-position+start-1,end);
		}
		return Integer.MAX_VALUE;
	}
	 public static int find_kth_smallest(int[] A, int n, int k) {
		 int end = n-1 ;
		 int start = 0;
		 return kth_smallest(A,start, k,end);
	
		 
	 }
}

