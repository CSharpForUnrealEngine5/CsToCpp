#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeTexture2DProperties : UInteractiveToolPropertySet {
// BakeTexture2DProperties
	public UTexture2D SourceTexture;
	public string UVLayer;
	public  TArray<string> GetUVLayerNamesFunc() { return default; }
	public TArray<string> UVLayerNamesList;
}
