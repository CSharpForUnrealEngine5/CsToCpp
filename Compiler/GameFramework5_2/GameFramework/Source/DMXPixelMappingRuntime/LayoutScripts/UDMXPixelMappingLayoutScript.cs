#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript.h")]
///<summary>Allows scripting of Pixel Mapping Component Layouts.</summary>
public partial class UDMXPixelMappingLayoutScript : UObject {
// DMXPixelMappingLayoutScript
	public void Layout(TArray<FDMXPixelMappingLayoutToken> InTokens,TArray<FDMXPixelMappingLayoutToken> OutTokens) {}
	public int NumTokens;
	public FVector2D ParentComponentPosition;
	public FVector2D ParentComponentSize;
	public FVector2D TextureSize;
}
