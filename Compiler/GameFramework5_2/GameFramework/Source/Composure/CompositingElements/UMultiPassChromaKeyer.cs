namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UMultiPassChromaKeyer : UCompositingElementTransform {
	public static UClass StaticClass() {return default;}
	///<summary>KeyColors</summary>
	public TArray<FLinearColor> KeyColors;
	///<summary>KeyerMaterial</summary>
	public FCompositingMaterial KeyerMaterial;
	///<summary>DefaultWhiteTexture</summary>
	public UTexture DefaultWhiteTexture;
}
