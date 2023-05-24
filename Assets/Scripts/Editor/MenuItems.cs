using UnityEngine;
using UnityEditor;


public static class MenuItems {
	/// <summary>
	/// EnemyPrefabëSçXêV
	/// </summary>
	[MenuItem("Custom/Verify to update Assets")]
	public static void UpdateMaterials() {
		var materialGUID = AssetDatabase.FindAssets("t:Object", new[] { "Assets" });
		foreach (var guid in materialGUID) {
			var path = AssetDatabase.GUIDToAssetPath(guid);
			AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
		}
	}
}
