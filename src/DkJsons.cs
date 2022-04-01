namespace Tool.Compet.Json {
	using Newtonsoft.Json;
	using UnityEngine;

	/// Json helper for converter Json vs Object.
	/// See https://www.jacksondunstan.com/articles/3303 to choose best approach on each serialize/deserialize.
	/// For eg,.
	/// - Serialize an object to json => Lit is optimal
	/// - Deserialize small string => Unity is optimal
	/// - Deserialize large string => Newton is optimal
	public class DkJsons {
		public static string Obj2Json(object serializableObj, Formatting formatting = Formatting.None) {
			return JsonConvert.SerializeObject(serializableObj, formatting);
		}

		/// Caller should add `where T : class` to its function to allow return nullable-result.
		public static T Json2Obj<T>(string json) where T : class {
			return JsonConvert.DeserializeObject<T>(json);
		}

		// public static string Obj2Json(object serializableObj, bool prettyPrint = false) {
		// 	return JsonUtility.ToJson(serializableObj, prettyPrint);
		// }

		// /// Caller should add `where T : class` to its function to allow return nullable-result.
		// public static T Json2Obj<T>(string json) where T : class {
		// 	return JsonUtility.FromJson<T>(json);
		// }
	}
}
