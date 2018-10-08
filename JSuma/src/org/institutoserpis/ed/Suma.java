package org.institutoserpis.ed;

import java.util.Scanner;

public class Suma {
	public static void main(String[] args) {
		 Scanner scanner=new Scanner(System.in);
			int num1,num2,suma;
		 System.out.println("Escribe un número");
			num1=scanner.nextInt();
		 System.out.println("Escribe otro número");
		    num2=scanner.nextInt();
		    suma=num1+num2;
		 System.out.println("El resultado de la suma es: "+ suma);
	}

}
