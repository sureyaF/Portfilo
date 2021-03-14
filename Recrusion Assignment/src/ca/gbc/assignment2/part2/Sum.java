package ca.gbc.assignment2.part2;

import java.util.HashSet;

/***********************************
 * COMP2080 - Assignment 2 File name: Sum.java Author:Farah, Sureya
 * Email: Your email address
 ************************************/
public class Sum {

	/**
	 * Returns true if array A contains two elements whose sum is k. Returns false
	 * otherwise. n is the number of elements A contains.
	 *
	 * The running time of your algorithm is O( ). You may add a brief explanation
	 * here if you wish.
	 * 
	 * @param A
	 * @param n
	 * @param k
	 * @return
	 */
	public static boolean sum(int[] A, int n, int k) {
		HashSet<Integer> element = new HashSet<Integer>();
		for (int j =0; j<n;j++) { // empty set
			// j pointer looks for matching element inside int n
			if(element.contains(k-A[j]))
				// if found returns true
				return true;
			// there were existing pair and displays the given sum
			element.add(A[j]);
		}
		return false;
			
	} 

	/**
	 * RECURSIVE ALGORITHM Returns true if array A contains two elements whose sum
	 * is k. Returns false otherwise. n is the number of elements A contains.
	 *
	 * The running time of your algorithm is O(n). You may add a brief explanation
	 * here if you wish.
	 *  because we traverse the entire array once in the recursion and says there were existing pair with given sum 
	 * @param A
	 * @param n
	 * @param k
	 * @return
	 */
	public static boolean sum_rec(int[] A, int n, int k) {
		HashSet<Integer> element = new HashSet<Integer>();
		return  ordpair_sum(A,0,k,element);
	} 
	
	public static boolean ordpair_sum(int [] A, int start, int k, HashSet<Integer> element){
		if (start == A.length)
			return false;
		if (element.contains(k-A[start]))
			return true;
		element.add(A[start]);
		return ordpair_sum(A, start+1, k , element);
	}
	

}
