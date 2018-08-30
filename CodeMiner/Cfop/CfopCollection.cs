using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeMiner.Cfop {

	/// <summary>
	/// Representa uma coleção de códigos CFOP.
	/// </summary>
	class CfopCollection: IEnumerable<Cfop> {

		/// <summary>
		/// Obtém o número de códigos CFOP na coleção.
		/// </summary>
		public int Count => cfops.Count;

		List<Cfop> cfops;

		public CfopCollection() => cfops = new List<Cfop>();

		/// <summary>
		/// Adiciona um código CFOP à coleção.
		/// </summary>
		/// <param name="cfop">Código CFOP.</param>
		public void Add(Cfop cfop) {
			if(cfops.Any(x => x.Value == cfop.Value))
				throw new ArgumentException($"O CFOP { cfop.Value } já está contido na coleção.");
			cfops.Add(cfop);
		}

		public IEnumerator<Cfop> GetEnumerator() => cfops.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	}

}
