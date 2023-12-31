namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithVREDSceneImportData : UDatasmithFBXSceneImportData {
	public static UClass StaticClass() {return default;}
	///<summary>bMergeNodes</summary>
	public bool bMergeNodes;
	///<summary>bOptimizeDuplicatedNodes</summary>
	public bool bOptimizeDuplicatedNodes;
	///<summary>bImportMats</summary>
	public bool bImportMats;
	///<summary>MatsPath</summary>
	public string MatsPath;
	///<summary>bImportVar</summary>
	public bool bImportVar;
	///<summary>bCleanVar</summary>
	public bool bCleanVar;
	///<summary>VarPath</summary>
	public string VarPath;
	///<summary>bImportLightInfo</summary>
	public bool bImportLightInfo;
	///<summary>LightInfoPath</summary>
	public string LightInfoPath;
	///<summary>bImportClipInfo</summary>
	public bool bImportClipInfo;
	///<summary>ClipInfoPath</summary>
	public string ClipInfoPath;
}
