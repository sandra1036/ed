package org.institutoserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class CaseAProbarTest {
	@Test
	void main() {
		assertEquals(0,ClaseAProbar.Valor_Inicial);
		ClaseAProbar.main(null);
		assertEquals(100,ClaseAProbar.Valor_Inicial);
	}

}
