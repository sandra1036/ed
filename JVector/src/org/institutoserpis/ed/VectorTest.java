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
	@Test
	void min() {
		int[] v =new int[] {16,12,15,14,17};
	//assertEquals(16,Vector.min(new int[] {16,12,15,14,17}));
	//assertEquals(9,Vector.min(new int[] {9,12,15,14,17};));
		assertEquals(12,Vector.min(new int[] {12,16,15,14,17}));
		assertEquals(12,Vector.min(new int[] {16,12,15,14,17}));
		assertEquals(12,Vector.min(new int[] {16,15,12,14,17}));
		assertEquals(12,Vector.min(new int[] {16,14,15,12,17}));
		assertEquals(12,Vector.min(new int[] {16,17,15,14,12}));

	}
	@Test
	void indexOfMin() {
		assertEquals(0,Vector.indexOfMin(new int[] {12,16,15,14,17}));
	    assertEquals(1,Vector.indexOfMin(new int[] {16,12,15,14,17}));
	    assertEquals(2,Vector.indexOfMin(new int[] {16,15,12,14,17}));
	    assertEquals(3,Vector.indexOfMin(new int[] {16,14,15,12,17}));
	    assertEquals(4,Vector.indexOfMin(new int[] {16,17,15,14,12}));
	}
	@Test
	void sort() {
		int[] v=new int[] {16,12,15,14,17};
		Vector.sort(v);
	}
}
