#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeTexture2DProperties : UInteractiveToolPropertySet {
	///<summary>Source mesh texture that is to be resampled into a new texture</summary>
	public UTexture2D SourceTexture;
	///<summary>UV channel to use for the source mesh texture</summary>
	public string UVLayer;
	///<summary>GetUVLayerNamesFunc</summary>
	public  TArray<string> GetUVLayerNamesFunc() { return default; }
	///<summary>UVLayerNamesList</summary>
	public TArray<string> UVLayerNamesList;
}
