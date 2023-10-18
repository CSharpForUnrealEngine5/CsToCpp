namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportData.h")]
public enum EFbxSceneReimportStatusFlags {
	None=0,
	Added=1,
	Removed=2,
	Same=4,
	FoundContentBrowserAsset=8,
	ReimportAsset=16,
}
