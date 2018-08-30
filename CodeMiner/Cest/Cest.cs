using System;

namespace CodeMiner.Cest {

	/// <summary>
	/// Representa um código CEST.
	/// </summary>
	class Cest {

		/// <summary>
		/// A descrição do código CEST.
		/// </summary>
		public string Description {
			get => description;
			set {
				if(string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("A descrição é inválida.");
				description = value;
			}
		}

		/// <summary>
		/// Os NCMs relacionados ao código CEST.
		/// </summary>
		public NcmCollection Ncms { get; }

		/// <summary>
		/// O valor do código CEST.
		/// </summary>
		public string Value {
			get => value;
			set {
				if(value.Length != 7)
					throw new ArgumentException("O valor é inválido.");
				foreach(char c in value)
					if(!char.IsDigit(c))
						throw new ArgumentException("O valor é inválido.");
				this.value = value;
			}
		}

		string description, value;

		public Cest() => Ncms = new NcmCollection();

	}

}
