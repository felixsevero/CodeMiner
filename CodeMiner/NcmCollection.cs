using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeMiner {

	/// <summary>
	/// Representa um código NCM, completo ou parcial.
	/// </summary>
	class NcmCollection: IEnumerable<string> {

		HashSet<string> ncms;

		public NcmCollection() => ncms = new HashSet<string>();

		/// <summary>
		/// Adiciona um código NCM à coleção.
		/// </summary>
		/// <param name="ncm">Código NCM.</param>
		public void Add(string ncm) {

			// Um CEST pode não estar vinculado com nenhum NCM.
			if(string.IsNullOrEmpty(ncm))
				return;

			foreach(char c in ncm)
				if(!char.IsDigit(c))
					throw new ArgumentException("O NCM é inválido.");
			if(ncm.Length < 4 || ncm.Length > 8)
				throw new ArgumentException("O NCM é inválido.");
			ncms.Add(ncm);
		}

		/// <summary>
		/// Adiciona um ou mais códigos NCM à coleção.
		/// </summary>
		/// <param name="ncms">Um ou mais códigos NCM.</param>
		public void AddRange(IEnumerable<string> ncms) {
			if(!CanAdd(ncms))
				return;
			foreach(string ncm in ncms)
				Add(ncm);
		}

		/// <summary>
		/// Alguns CESTs indicam Capítulos, ao invés de NCMs.
		/// Verifica se os NCMs são válidos.
		/// </summary>
		/// <param name="ncms">NCMs para verificar.</param>
		/// <returns>Um valor que indica se os NCMs são válidos.</returns>
		bool CanAdd(IEnumerable<string> ncms) {
			foreach(string ncm in ncms)
				if(ncm.StartsWith("Capítulo", StringComparison.OrdinalIgnoreCase))
					return false;
			return true;
		}

		public IEnumerator<string> GetEnumerator() => ncms.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	}

}
