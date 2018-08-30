using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeMiner {

	/// <summary>
	/// Representa um arquivo de Log.
	/// </summary>
	class Log: IEnumerable<string> {

		List<string> entries;

		public Log() => entries = new List<string>();

		/// <summary>
		/// Adiciona uma entrada ao arquivo.
		/// </summary>
		/// <param name="entry">A entrada para adição.</param>
		public void Add(string entry) {
			if(string.IsNullOrWhiteSpace(entry))
				throw new ArgumentException("O lançamento de log é inválido.");
			entries.Add(entry);
		}

		public IEnumerator<string> GetEnumerator() => entries.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	}

}
