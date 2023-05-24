using UnityEngine;
using UnityEditor;


public static class MenuItems {
	[MenuItem("Custom/Verify to update Assets")]
	public static void UpdateMaterials() {
		var guids = AssetDatabase.FindAssets("t:Object", new[] { "Assets" });
		foreach (var guid in guids) {
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var importer = AssetImporter.GetAtPath(path);
			EditorUtility.SetDirty(importer);
			importer.SaveAndReimport();
		}
	}
}
