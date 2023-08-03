#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options used when importing any mesh from FBX</summary>
[CppInclude("Factories/FbxTextureImportData.h")]
public partial class UFbxTextureImportData : UFbxAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>If importing textures is enabled, this option will cause normal map Y (Green) values to be inverted</summary>
	public bool bInvertNormalMaps;
	///<summary>Specify where we should search for matching materials when importing</summary>
	public EMaterialSearchLocation MaterialSearchLocation;
	///<summary>Base material to instance from when importing materials.</summary>
	public FSoftObjectPath BaseMaterialName;
	///<summary>BaseColorName</summary>
	public string BaseColorName;
	///<summary>BaseDiffuseTextureName</summary>
	public string BaseDiffuseTextureName;
	///<summary>BaseNormalTextureName</summary>
	public string BaseNormalTextureName;
	///<summary>BaseEmissiveColorName</summary>
	public string BaseEmissiveColorName;
	///<summary>BaseEmmisiveTextureName</summary>
	public string BaseEmmisiveTextureName;
	///<summary>BaseSpecularTextureName</summary>
	public string BaseSpecularTextureName;
	///<summary>BaseOpacityTextureName</summary>
	public string BaseOpacityTextureName;
}
