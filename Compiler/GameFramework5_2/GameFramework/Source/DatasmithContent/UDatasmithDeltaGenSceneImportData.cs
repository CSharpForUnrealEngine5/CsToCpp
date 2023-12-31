namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithDeltaGenSceneImportData : UDatasmithFBXSceneImportData {
	public static UClass StaticClass() {return default;}
	///<summary>bMergeNodes</summary>
	public bool bMergeNodes;
	///<summary>bOptimizeDuplicatedNodes</summary>
	public bool bOptimizeDuplicatedNodes;
	///<summary>bRemoveInvisibleNodes</summary>
	public bool bRemoveInvisibleNodes;
	///<summary>bSimplifyNodeHierarchy</summary>
	public bool bSimplifyNodeHierarchy;
	///<summary>bImportVar</summary>
	public bool bImportVar;
	///<summary>VarPath</summary>
	public string VarPath;
	///<summary>bImportPos</summary>
	public bool bImportPos;
	///<summary>PosPath</summary>
	public string PosPath;
	///<summary>bImportTml</summary>
	public bool bImportTml;
	///<summary>TmlPath</summary>
	public string TmlPath;
}
