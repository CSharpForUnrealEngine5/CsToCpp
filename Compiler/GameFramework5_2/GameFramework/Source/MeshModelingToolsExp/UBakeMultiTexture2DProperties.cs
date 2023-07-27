#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeMultiTexture2DProperties : UInteractiveToolPropertySet {
// BakeMultiTexture2DProperties
	public TArray<UTexture2D> MaterialIDSourceTextures;
	public string UVLayer;
	public  TArray<string> GetUVLayerNamesFunc() { return default; }
	public TArray<string> UVLayerNamesList;
	public TArray<UTexture2D> AllSourceTextures;
}
