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
  
}
