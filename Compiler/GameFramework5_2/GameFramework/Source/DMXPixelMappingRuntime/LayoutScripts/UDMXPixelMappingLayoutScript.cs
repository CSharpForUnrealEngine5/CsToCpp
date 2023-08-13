namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows scripting of Pixel Mapping Component Layouts.</summary>
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript.h")]
public partial class UDMXPixelMappingLayoutScript : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Lays out children of the selection according to OutTokens. Tokens that are not returned remain unchanged.</summary>
	public void Layout(TArray<FDMXPixelMappingLayoutToken> InTokens,TArray<FDMXPixelMappingLayoutToken> OutTokens) {}
	///<summary>The number of tokens in the Layout.</summary>
	public int NumTokens;
	///<summary>The position of the parent component where the components that are being layouted reside in.</summary>
	public FVector2D ParentComponentPosition;
	///<summary>The size of the parent component where the components that are being layouted reside in.</summary>
	public FVector2D ParentComponentSize;
	///<summary>The size of the texture in the Pixel Mapping asset.</summary>
	public FVector2D TextureSize;
}
