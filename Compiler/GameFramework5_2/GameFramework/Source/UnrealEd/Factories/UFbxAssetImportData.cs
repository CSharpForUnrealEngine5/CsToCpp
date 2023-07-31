#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing any asset from FBX</summary>
[CppInclude("Factories/FbxAssetImportData.h")]
public partial class UFbxAssetImportData : UAssetImportData {
	///<summary>ImportTranslation</summary>
	public FVector ImportTranslation;
	///<summary>ImportRotation</summary>
	public FRotator ImportRotation;
	///<summary>ImportUniformScale</summary>
	public float ImportUniformScale;
	///<summary>Convert the scene from FBX coordinate system to UE coordinate system</summary>
	public bool bConvertScene;
	///<summary>Convert the scene from FBX coordinate system to UE coordinate system with front X axis instead of -Y</summary>
	public bool bForceFrontXAxis;
	///<summary>Convert the scene from FBX unit to UE unit (centimeter).</summary>
	public bool bConvertSceneUnit;
	///<summary>Use by the reimport factory to answer CanReimport, if true only factory for scene reimport will return true</summary>
	public bool bImportAsScene;
	///<summary>Use by the reimport factory to answer CanReimport, if true only factory for scene reimport will return true</summary>
	public UFbxSceneImportData FbxSceneImportDataReference;
}
