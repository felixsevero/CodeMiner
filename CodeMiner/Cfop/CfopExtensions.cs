using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeMiner.Cfop {

	/// <summary>
	/// Possui métodos estáticos úteis para a mineração e manipulação de códigos CFOP.
	/// </summary>
	static class CfopExtensions {

		/// <summary>
		/// Obtém uma coleção de códigos CFOP.
		/// </summary>
		/// <param name="lines">As linhas com os códigos CFOP.</param>
		/// <param name="log">O arquivo de Log.</param>
		/// <returns>A coleção de códigos CFOP.</returns>
		public static CfopCollection GetCfopCollection(this string[] lines, Log log) {
			CfopCollection cfops = new CfopCollection();
			for(int i = 1; i < lines.Length; i++)
				TryAdd(lines[i], cfops, log);
			return cfops;
		}

		/// <summary>
		/// Obtém as linhas do arquivo, as quais possuem os códigos CFOP.
		/// </summary>
		/// <param name="filePath">O caminho do arquivo.</param>
		/// <returns>As linhas do arquivo.</returns>
		public static string[] GetFileContent(this string filePath) {
			string[] lines = File.ReadAllLines(filePath, Encoding.Default);
			return lines;
		}

		/// <summary>
		/// Salva a coleção de códigos CFOP em arquivo Json.
		/// </summary>
		/// <param name="cfops">A coleção de códigos CFOP.</param>
		/// <param name="path">O local do salvamento.</param>
		public static void SaveToJson(this CfopCollection cfops, string path) {
			string json = JsonConvert.SerializeObject(cfops);
			DateTime dateTime = DateTime.Now;
			string fileName = $"CodeMiner_CFOP_{ dateTime.Year }_{ dateTime.Month }_{ dateTime.Day }_{ dateTime.Hour }_{ dateTime.Minute }_{ dateTime.Second }.json";
			string fullFilePath = Path.Combine(path, fileName);
			File.WriteAllText(fullFilePath, json, Encoding.Default);
		}

		/// <summary>
		/// Caso possível, adiciona o código CFOP da linha à coleção.
		/// </summary>
		/// <param name="line">A linha para adição.</param>
		/// <param name="cfops">A coleção.</param>
		/// <param name="log">O arquivo de Log.</param>
		static void TryAdd(string line, CfopCollection cfops, Log log) {
			string[] parts = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			if(parts.Length < 3 || parts.Length > 4)
				throw new InvalidDataException("A linha é inválida.");
			string value = parts[0];
			string description = parts[1];
			if(!Validate(value, parts, log))
				return;
			Cfop cfop = new Cfop() {
				Description = description,
				Value = value
			};
			cfops.Add(cfop);
		}

		/// <summary>
		/// Verifica as datas de cada CFOP e, se necessário, questiona o usuário se o CFOP deve ser adicionado à coleção.
		/// </summary>
		/// <param name="value">O valor do CFOP.</param>
		/// <param name="parts">As partes da linha.</param>
		/// <param name="log">O arquivo de Log.</param>
		/// <returns>Um valor que indica se o CFOP deve ser adicionado à coleção.</returns>
		static bool Validate(string value, string[] parts, Log log) {
			DateTime beginDate = DateTime.ParseExact(parts[2], "ddMMyyyy", CultureInfo.InvariantCulture);
			if(beginDate > DateTime.Today) {
				string message = $"O CFOP { value } com vigência a partir de { beginDate.ToShortDateString() } deve ser inserido?";
				if(MessageBox.Show(message, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
					log.Add($"O CFOP { value } com vigência a partir de { beginDate.ToShortDateString() } foi ignorado.");
					return false;
				}
			}
			if(parts.Length == 4) {
				DateTime endDate = DateTime.ParseExact(parts[3], "ddMMyyyy", CultureInfo.InvariantCulture);
				string message = $"O CFOP { value } com vigência entre { beginDate.ToShortDateString() } e { endDate.ToShortDateString() } deve ser inserido?";
				if(MessageBox.Show(message, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
					log.Add($"O CFOP { value } com vigência entre { beginDate.ToShortDateString() } e { endDate.ToShortDateString() } foi ignorado.");
					return false;
				}
			}
			return true;
		}

	}

}
