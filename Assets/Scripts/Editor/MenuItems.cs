using UnityEngine;
using UnityEditor;


public static class MenuItems {
	/// <summary>
	/// EnemyPrefab全更新
	/// </summary>
	[MenuItem("Custom/Dirty Materials")]
	public static void UpdateMaterials() {
		var materialGUID = AssetDatabase.FindAssets("t:Material");
		foreach (var guid in materialGUID) {
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var mat = AssetDatabase.LoadAssetAtPath<Material>(path);
			EditorUtility.SetDirty(mat);
		}
	}
	/// <summary>
	/// EnemyPrefab全更新
	/// </summary>
	[MenuItem("Custom/Dirty ScriptableObject")]
	public static void UpdateSO() {
		var materialGUID = AssetDatabase.FindAssets("t:ScriptableObject");
		foreach (var guid in materialGUID) {
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var mat = AssetDatabase.LoadAssetAtPath<ScriptableObject>(path);
			EditorUtility.SetDirty(mat);
		}
	}
	/// <summary>
	/// EnemyPrefab全更新
	/// </summary>
	[MenuItem("Custom/Dirty Prefabs")]
	public static void UpdatePrefabs() {
		var materialGUID = AssetDatabase.FindAssets("t:Prefab");
		foreach (var guid in materialGUID) {
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var mat = AssetDatabase.LoadAssetAtPath<GameObject>(path);
			EditorUtility.SetDirty(mat);
		}
	}
}
