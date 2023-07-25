#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithAssetImportData.h")]
public partial class UDatasmithVREDSceneImportData : UDatasmithFBXSceneImportData {
// DatasmithVREDSceneImportData
	public bool bMergeNodes;
	public bool bOptimizeDuplicatedNodes;
	public bool bImportMats;
	public string MatsPath;
	public bool bImportVar;
	public bool bCleanVar;
	public string VarPath;
	public bool bImportLightInfo;
	public string LightInfoPath;
	public bool bImportClipInfo;
	public string ClipInfoPath;
}
