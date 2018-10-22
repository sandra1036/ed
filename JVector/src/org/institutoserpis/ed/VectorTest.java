package org.institutoserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest {

	@Test
	void indexOF() {
		
	  int[] v =new int[] {16,12,15,14,17};
	  
	  assertEquals(0,Vector.indexOF(v, 16));
	  assertEquals(2,Vector.indexOF(v, 15));
	  assertEquals(4,Vector.indexOF(v, 17));
	  assertEquals(-1,Vector.indexOF(v, 33));

	}
	@Test
	void indexOfEmpty() {
		int[] v=new int[] {};
	      assertEquals(-1,Vector.indexOF(v, 22));

	}
}
