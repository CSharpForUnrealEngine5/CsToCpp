#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxTextureImportData.h")]
///<summary>Import data and options used when importing any mesh from FBX</summary>
public partial class UFbxTextureImportData : UFbxAssetImportData {
// FbxTextureImportData
	public bool bInvertNormalMaps;
	public EMaterialSearchLocation MaterialSearchLocation;
	public FSoftObjectPath BaseMaterialName;
	public string BaseColorName;
	public string BaseDiffuseTextureName;
	public string BaseNormalTextureName;
	public string BaseEmissiveColorName;
	public string BaseEmmisiveTextureName;
	public string BaseSpecularTextureName;
	public string BaseOpacityTextureName;
}
