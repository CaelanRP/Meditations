using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.Security.Cryptography;
//using UnityEditor;

public static class TTUtil {
	private static System.Random r;

	public const string MixerBlue = "307EFDFF";
	public const string Gold = "C9A618FF";
	public const string AuraPurple = "9A00D0FF";
	public const string HealthyGreen = "54AC31FF";
	public const string SoftRed = "FF1460FF";

	public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";


	public static string GetPercentageString(float f){
		return String.Format("{0:00\\%}", f*100);
	}

	public static float GetNormalDistFloat(float mean, float stdDev){
		double u1 = 1.0-random.NextDouble(); //uniform(0,1] random doubles
		double u2 = 1.0-random.NextDouble();
		double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
             Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
		double randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)

		return (float)randNormal;
	}

	public static float GetNormalDistFloat(float mean, float stdDev, float min, float max){
		float norm = GetNormalDistFloat(mean, stdDev);
		norm = Mathf.Max(min, norm);
		norm = Mathf.Min(max, norm);

		return norm;
	}

	public static char GetAlphabetCharacter(int index){
		try{
			return Alphabet[index];
		}
		catch (Exception e) {
			Debug.Log(e);
			return '?';
		}
	}

	public static System.Random random{
		get{
			if (r == null){
				r = new System.Random();
			}
			return r;
		}
	}

	public static bool Coinflip(){
		return(random.NextDouble() > 0.5);
	}

	public static float Vector2ToDegrees(Vector2 vec){
		return Vector2.SignedAngle(Vector2.right, vec);
	}

	public static Vector2 DegreesToVector2(float degrees){
		float rads = degrees * Mathf.Deg2Rad;
		Vector2 vec = new Vector2 (Mathf.Cos(rads), Mathf.Sin(rads)).normalized;
		return vec;
	}

	public static string GetDictionaryAsJSON(Dictionary<string, string> data, bool standalone = false) {
        string dataString = "";
        if (standalone){
            dataString += "{";
        }
        foreach (KeyValuePair<string, string> entry in data) {
            if (entry.Value.Contains("{")) // IF value is a custom JSON string.
                dataString += "\"" + entry.Key + "\": " + entry.Value + ",";
            else
                dataString += "\"" + entry.Key + "\": \"" + entry.Value + "\", ";
        }
		int index = dataString.LastIndexOf(",");
		if (index != -1)
        	dataString = dataString.Remove(dataString.LastIndexOf(','), 1);
        if (standalone){
            dataString += "}";
        }
        return dataString;
    }

	public static int GetRandomIndex(System.Object[] arr){
		if (arr.Length == 0){
			return -1;
		}
		return r.Next(0,arr.Length);
	}

	public static Color ColorFromHex(string hex){
		Color color = Color.white;
		if (!hex[0].Equals('#')){
			hex = "#" + hex;
		}
		ColorUtility.TryParseHtmlString(hex, out color);
		return color;
	}

	public static string ColorText(string text, Color c){
		string colorTag = ColorUtility.ToHtmlStringRGB(c);
        return "<#" + colorTag + ">" + text + "</color>";
	}

	public static string ColorText(string text, string hex){
        return "<#" + hex + ">" + text + "</color>";
	}

	public static string ColorFromH(string text, Color c){
		string colorTag = ColorUtility.ToHtmlStringRGB(c);
        return "<#" + colorTag + ">" + text + "</color>";
	}

	public static string ListToString(List<object> list){
		string stringToPrint = "[";
		for(int i = 0; i < list.Count; i++){
			stringToPrint += list[i].ToString();
			if (i < list.Count-1){
				stringToPrint += ", ";
			}
		}
		stringToPrint += "]";
		return stringToPrint;
	}

	public static string ListToString(object[] list){
		string stringToPrint = "[";
		for(int i = 0; i < list.Length; i++){
			stringToPrint += list[i].ToString();
			if (i < list.Length-1){
				stringToPrint += ", ";
			}
		}
		stringToPrint += "]";
		return stringToPrint;
	}

	public static void Shuffle<T>(this IList<T> list) {
		r = new System.Random();
		int n = list.Count;
		while (n > 1) {
			n--;
			int k = r.Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}

	/// <summary>
	///	Returns a list of strings as a JSON string. If provided with an id, will return as a JSON object
	/// </summary>
	/// <param name="list">List to convert</param>
	/// <param name="id">Optional identifier</param>
	public static string GetListAsJSONString(List<string> list, string id = null) {
		string result = "";
		if (!string.IsNullOrEmpty(id))
			result += "\"" + id + "\": ";
		result += "[";
		if (list != null && list.Count > 0) {
			result += "\"" + list[0] + "\"";
			for (int i = 1; i < list.Count; i++) {
				result += ", \"" + list[i] + "\"";
			}
		}
		result += "]";
		return result;
	}

	public static string GetDictAsJSONString(Dictionary<string, string> dict, string id = null) {
		string result = "";
		if (!string.IsNullOrEmpty(id))
			result += "\"" + id + "\": ";
		result += "{";
		if (dict != null && dict.Count > 0) {
			foreach (var item in dict)
			{
				result += "\"" + item.Key + "\":";
				result += "\"" + item.Value + "\", ";
			}
		}
		result += "}";
		return result;
	}

	public static T Random<T>(this IEnumerable<T> enumerable, Func<T, int> weightFunc)
    {
        int totalWeight = 0; // this stores sum of weights of all elements before current
        T selected = default(T); // currently selected element
        foreach (var data in enumerable)
        {
            int weight = weightFunc(data); // weight of current element
            int value = random.Next(totalWeight + weight); // random value
            if (value >= totalWeight) // probability of this is weight/(totalWeight+weight)
                selected = data; // it is the probability of discarding last selected element and selecting current one instead
            totalWeight += weight; // increase weight sum
        }

		if (selected == null){

		}

        return selected; // when iterations end, selected is some element of sequence. 
    }

	public static T RandomSelection<T>(List<T> list)
    {
		if (list == null || list.Count == 0){
			return default(T);
		}
        return list[random.Next(0,list.Count)]; // when iterations end, selected is some element of sequence. 
    }

	public static int SampleMultinomial(float[] ps) {
		float f = (float)random.NextDouble();
		float c = 0.0f;
		for (int i = 0; i < ps.Length; ++i) {
			c += ps[i];
			if (c > f) {
			return i;
			}
		}
		return ps.Length - 1;
    }

	public static int SampleMultinomialWeighted(float[] weights){
		float sum = 0;
		float[] ps = new float[weights.Length];
			for(int i = 0; i < weights.Length; i++){
				sum += weights[i];
			}
			// If there are no weights, return a random index
			if (sum == 0){
				return r.Next(0,weights.Length);
			}

			for(int i = 0; i < weights.Length; i++){
				ps[i] = (weights[i]) / sum;
			}
			int index = SampleMultinomial(ps);
			return index;
	}
}