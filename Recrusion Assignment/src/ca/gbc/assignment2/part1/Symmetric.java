package ca.gbc.assignment2.part1;
/***********************************
 * COMP2080 - Assignment 2 File name: Symmetric.java Author: Farah, Sureya
 *  Email: sureya.farah@georgebrown.ca
 ************************************/
import java.util.Arrays;
public class Symmetric {

	/**
	 * Returns true if array A is symmetric. Returns false otherwise. n is the
	 * number of elements A contains.
	 * 
	 * The running time of your algorithm is O( ). You may add a brief explanation
	 * here if you wish.
	 * 
	 * @param A
	 * @param n
	 * @return
	 */
	public static boolean symmetric(int[] A, int n) {
		//if array (A) length is 0 or 1, return true
		if (n==0 || n==1) 
			return true;
		// check whether first and last element of array is equal
		if (A[0] == A[n-1]) {
			//To get sub-array we need to import java.util.Array;
			int [] Ar = Arrays.copyOfRange(A,1,n-1);
			return Symmetric.symmetric(Ar, n-2); // recursive call
		}
		else
			return false;
	}

}
