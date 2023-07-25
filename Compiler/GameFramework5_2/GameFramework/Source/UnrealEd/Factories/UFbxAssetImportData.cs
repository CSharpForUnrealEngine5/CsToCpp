#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxAssetImportData.h")]
///<summary>Base class for import data and options used when importing any asset from FBX</summary>
public partial class UFbxAssetImportData : UAssetImportData {
// FbxAssetImportData
	public FVector ImportTranslation;
	public FRotator ImportRotation;
	public float ImportUniformScale;
	public bool bConvertScene;
	public bool bForceFrontXAxis;
	public bool bConvertSceneUnit;
	public bool bImportAsScene;
	public UFbxSceneImportData FbxSceneImportDataReference;
}
