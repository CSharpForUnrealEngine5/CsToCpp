#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UMultiPassChromaKeyer : UCompositingElementTransform {
// MultiPassChromaKeyer
	public TArray<FLinearColor> KeyColors;
	public FCompositingMaterial KeyerMaterial;
	public UTexture DefaultWhiteTexture;
}
