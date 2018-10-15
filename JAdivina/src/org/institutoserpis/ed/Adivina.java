package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class Adivina {
   public static void main(String[]args) {
	   Random random = new Random();
	    int numeroAleatorio= random.nextInt(1000)+1;
	    Scanner scanner=new Scanner(System.in);
	    int contador=0;
	    int minimo=1;
	    int maximo=1000;
	    contador++;
	    System.out.printf("Adivina un número (entre %s y %s)[intento %s]", minimo,maximo,contador);
	    int num=scanner.nextInt();
	     while (num !=numeroAleatorio) {
	    	 if(num<numeroAleatorio) {
	    		 System.out.println("Es mayor que ese");
	    		 minimo=num+1;
	    	 }else {
	    		 
	    		 System.out.println("Es menor que ese");
	    		 maximo=num-1;
	    	 }
	    	 contador++;
	    		 System.out.printf("Adivina un número (entre %s y %s)[intento %s]", minimo,maximo,contador);
	    		 num=scanner.nextInt();
	     }
	   System.out.println("Enhorabuena has encontrado el número.");
   }
}
