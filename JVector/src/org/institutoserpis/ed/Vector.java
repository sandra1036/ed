package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
       int[] v =new int[] {16,12,15,14,17};
       for(int item:v)
    	   System.out.println(item);
       
       
       int index= indexOF(v,12);
       System.out.println("index="+index);
	}
   public static int indexOF(int[] v, int x ) {
	  // int index=0;
	  // while (index < v.length  && v[index]!=x)
	//	    index++;
	//   if(index==v.length)
	//	   return -1;
	  //     return index;
	   for (int index= 0; index<v.length;index++)
		   if(v[index]==x)
		      return index;
	       return -1;
	   
   }

   public static int min(int[] v ) {
	   int min=v[0];
	for(int index= 1; index< v.length;index++) {
		if(v[index]<min)
			min=v[index];
		//int indexOfMIn=indexOfMin(v);
		//return v[indexOfMin];
		 
   }
	  return min; //TODO implementar
  }
   public static int indexOfMin(int[]v) {
	   int indexOfMin=0 ;
	 for(int index= 1; index< v.length;index++) {
		  if(v[index]<v[indexOfMin])
			  indexOfMin=index;
   }
	  return indexOfMin;
   }
   public static void sort(int[]v) {
	  int indexOfMin=0;
	for(int vector=0;vector<v.length-1;vector ++) {  
	  for(int index=1; index<v.length;index++) {
		  if(v[index]<indexOfMin) {
			  indexOfMin=index;
		  }		  
	  }
	  int aux = v[0];
	  v[0]=v[indexOfMin];
	  v[indexOfMin]=aux;
   }
   }
	private static int indexofMin(int[] v, int initialIndex) {
		return -1;
	}
	public static void swap(int[]v,int indexOne,int indexTwo) {
		int aux=v[indexOne];
		v[indexOne]=v[indexTwo];
		v[indexTwo]=aux;
	 // for(int index=0;index< v.length-1;index++)
	//  swap(v,index,indexOfMin(v,index));
	}
}
