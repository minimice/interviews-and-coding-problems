// CHOOI GUAN LIM solution
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

public class Solution
{
	static public int Run(string character)
	{
		// Search for the person
		Task<string> result = SearchForCharacter(character);
		var jsonResult = result.Result;
		JObject results = JsonConvert.DeserializeObject<JObject>(jsonResult);
		List<string> str = results["results"].First["films"].ToObject<List<string>>();
		//Console.WriteLine(str.Count);
		return str.Count;
	}

	public static async Task<string> SearchForCharacter(string character)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetAsync("https://challenges.hackajob.co/swapi/api/people/?search=" + character);
		var contents = await response.Content.ReadAsStringAsync();
		return contents;
	}
}