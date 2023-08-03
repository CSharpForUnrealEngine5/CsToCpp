#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeMultiTexture2DProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>For each material ID, the source texture that will be resampled in that material&#39;s region</summary>
	public TArray<UTexture2D> MaterialIDSourceTextures;
	///<summary>UV channel to use for the source mesh texture</summary>
	public string UVLayer;
	///<summary>GetUVLayerNamesFunc</summary>
	public  TArray<string> GetUVLayerNamesFunc() { return default; }
	///<summary>UVLayerNamesList</summary>
	public TArray<string> UVLayerNamesList;
	///<summary>The set of all source textures from all input materials</summary>
	public TArray<UTexture2D> AllSourceTextures;
}
