using System;

namespace CodeMiner.Cfop {

	/// <summary>
	/// Representa um código CFOP.
	/// </summary>
	class Cfop {

		/// <summary>
		/// A descrição do código CFOP.
		/// </summary>
		public string Description {
			get => description;
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("A descrição é inválida.");
				value = value.Trim();
				if(!value.EndsWith("."))
					value = value + '.';
				description = value;
			}
		}

		/// <summary>
		/// O valor do código CFOP.
		/// </summary>
		public string Value {
			get => value;
			set {
				if(value.Length != 4)
					throw new ArgumentException("O valor é inválido.");
				foreach(char c in value)
					if(!char.IsDigit(c))
						throw new ArgumentException("O valor é inválido.");
				this.value = value;
			}
		}

		string description, value;

	}

}
