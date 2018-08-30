using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeMiner.Cest {

	/// <summary>
	/// Possui métodos estáticos úteis para a mineração e manipulação de códigos CEST.
	/// </summary>
	static class CestExtensions {

		/// <summary>
		/// Obtém uma coleção de códigos CEST.
		/// </summary>
		/// <param name="htmlNodes">Nodos com os códigos CEST.</param>
		/// <returns>Coleção de códigos CEST.</returns>
		public static CestCollection GetCestCollection(this IEnumerable<HtmlNode> htmlNodes) {
			CestCollection cests = new CestCollection();
			foreach(HtmlNode htmlNode in htmlNodes)
				AddToCollection(htmlNode, cests);
			return cests;
		}

		/// <summary>
		/// Obtém as linhas válidas com os códigos CEST.
		/// </summary>
		/// <param name="htmlDocument"></param>
		/// <returns>Nodos com os códigos CEST.</returns>
		public static IEnumerable<HtmlNode> GetRows(this HtmlDocument htmlDocument) {
			List<HtmlNode> list = new List<HtmlNode>();
			IEnumerable<HtmlNode> rows = htmlDocument.DocumentNode.Descendants("tr");
			foreach(HtmlNode row in rows)
				TryAddRow(row, list);
			return list;
		}

		/// <summary>
		/// Obtém um documento com o conteúdo web, o qual possui os códigos CEST.
		/// </summary>
		/// <param name="uri">URI com o endereço web.</param>
		/// <returns>Documento com os códigos CEST.</returns>
		public static HtmlDocument GetWebContent(this Uri uri) {
			HtmlWeb htmlWeb = new HtmlWeb();
			HtmlDocument htmlDocument = htmlWeb.Load(uri);
			return htmlDocument;
		}

		/// <summary>
		/// Salva a coleção de códigos CEST em arquivo Json.
		/// </summary>
		/// <param name="cests">Coleção de códigos CEST.</param>
		/// <param name="path">Local do salvamento.</param>
		public static void SaveToJson(this CestCollection cests, string path) {
			string json = JsonConvert.SerializeObject(cests);
			DateTime dateTime = DateTime.Now;
			string fileName = $"CodeMiner_CEST_{ dateTime.Year }_{ dateTime.Month }_{ dateTime.Day }_{ dateTime.Hour }_{ dateTime.Minute }_{ dateTime.Second }.json";
			string fullFilePath = Path.Combine(path, fileName);
			File.WriteAllText(fullFilePath, json, Encoding.UTF8);
		}

		/// <summary>
		/// Caso válido, adiciona o código CEST à coleção. Caso ele já esteja presente, verifica se existem NCMs para adicionar.
		/// </summary>
		/// <param name="htmlNode">Nodo com o código CEST.</param>
		/// <param name="cests">Coleção de códigos CEST.</param>
		static void AddToCollection(HtmlNode htmlNode, CestCollection cests) {
			HtmlNodeCollection htmlNodeCollection = htmlNode.SelectNodes("td");
			string value = htmlNodeCollection[1].InnerText.Clean();
			string[] ncms = htmlNodeCollection[2].InnerText.CleanAndSplit();
			string description = htmlNodeCollection[3].InnerText.Trim();
			if(value.Equals("CEST", StringComparison.OrdinalIgnoreCase))
				return;
			Cest cest = new Cest() {
				Description = description,
				Value = value
			};
			cest.Ncms.AddRange(ncms);
			cests.Add(cest);
		}

		static string Clean(this string str) => str.Trim().Replace(".", string.Empty).Replace(",", string.Empty);

		static string[] CleanAndSplit(this string str) => str.Clean().Split(' ', '\n');

		/// <summary>
		/// Verifica se a linha é válida para a adição na coleção.
		/// </summary>
		/// <param name="row">Linha para verificação.</param>
		/// <param name="list">Lista para adição.</param>
		static void TryAddRow(HtmlNode row, List<HtmlNode> list) {
			HtmlNodeCollection htmlNodeCollection = row.SelectNodes("td");

			// A linha é válida caso possua 4 colunas.
			if(htmlNodeCollection.Count != 4)
				return;

			// A linha é válida caso não seja verde.
			foreach(HtmlNode htmlNode in htmlNodeCollection) {
				string value = htmlNode.SelectSingleNode("p").Attributes["class"].Value;
				if(value == "TabelaSubtituloverde")
					return;
			}
			list.Add(row);
		}

	}

}
