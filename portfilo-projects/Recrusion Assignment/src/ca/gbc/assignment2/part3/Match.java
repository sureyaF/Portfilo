package ca.gbc.assignment2.part3;
/***********************************
 * COMP2080 - Assignment 2 File name: Match.java Author: Farah, Sureya
 *  Email: sureya.farah@georgebrown.ca
 ************************************/
public class Match {

/**
 * Returns index i if array A contains an element A[i] such that A[i] = i.
 * If there exist many of such elements, return the index of any one of them.
 * Returns -1 if there exists no element A[i] such that A[i] == i.
 * n is the number of elements A contains.
 *
 * The running time of your algorithm is O(  ).
 * You may add a brief explanation here if you wish.
 * 
 * @param A
 * @param n
 * @return
 */
public static int binarySearch(int [] A, int start, int end) {
		// non negative integer end 
		if (end >= start) {
			// the sum of the mid in (A) starting at index A
			int mid = (start + end ) / 2;
			if(A[mid] == mid)
			return mid;
			
			
			
			if (A[mid] > mid)
				return binarySearch(A, start, mid - 1 );
			return binarySearch(A, mid +1, end);
		}
		return -1;
	}

public static int match( int[] A, int n ) 
{
   int pointer;
   pointer = binarySearch(A,0,n);
   return pointer;
} 

/**
 * Returns index i if array A contains an element A[i] such that A[i] = i.
 * If there exist many of such elements, return the index of any one of them.
 * Returns -1 if there exists no element A[i] such that A[i] == i.
 * n is the number of elements A contains.
 *
 * The running time of your algorithm is O(n).
 * You may add a brief explanation here if you wish.
 * binary search takes a divide and conquer algorithm 
 * the match _rec is o(n) because we are check every index recursively
 * @param A
 * @param n
 * @return
 */
public static int match_iterative(int [] A, int n) {
	int i ;
	for (i=0; i<n; i++) {
		if (A[i] == i )
			return i;
		
	}
	return -1;
}

public static int match_rec( int[] A, int n )
{
   if (n < 1) {
	   return -1;
   }
   if (A[n-1]==n-1) { 
	   return n-1;
   }
   return match_rec(A, n-1);
}

} // end class

