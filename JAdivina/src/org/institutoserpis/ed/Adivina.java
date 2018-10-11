package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {
   public static void main(String[]args) {
	   Random random = new Random();
	    int numeroAleatorio= random.nextInt(1000)+1;
	    Scanner scanner=new Scanner(System.in);
	    System.out.println("Adivina un número (entre 1 y 1000)");
	    int num=scanner.nextInt();
	     while (num !=numeroAleatorio) {
	    	 if(num<numeroAleatorio)
	    		 System.out.println("Es mayor que ese");
	    	 else 
	    		 System.out.println("Es menor que ese");
	    		 System.out.println("Adivina un número (entre 1 y 1000)");
	    		 num=scanner.nextInt();
	     }
	   
   }
}
