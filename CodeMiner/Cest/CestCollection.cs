using System.Collections;
using System.Collections.Generic;

namespace CodeMiner.Cest {

	/// <summary>
	/// Representa uma coleção de códigos CEST.
	/// </summary>
	class CestCollection: IEnumerable<Cest> {

		/// <summary>
		/// Obtém o número de códigos CEST na coleção.
		/// </summary>
		public int Count => cests.Count;

		List<Cest> cests;

		public CestCollection() => cests = new List<Cest>();

		/// <summary>
		/// Adiciona um código CEST à coleção.
		/// </summary>
		/// <param name="cest">Código CEST.</param>
		public void Add(Cest cest) {
			Cest c = GetDuplicate(cest);
			if(c == null) {
				cests.Add(cest);
				return;
			}
			foreach(string ncm in cest.Ncms)
				c.Ncms.Add(ncm);
		}

		Cest GetDuplicate(Cest cest) {
			foreach(Cest c in cests)
				if(c.Value == cest.Value)
					return c;
			return null;
		}

		public IEnumerator<Cest> GetEnumerator() => cests.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	}

}
