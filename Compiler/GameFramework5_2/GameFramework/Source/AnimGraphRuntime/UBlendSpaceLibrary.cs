#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a blend space anim node.</summary>
[CppInclude("BlendSpaceLibrary.h")]
public partial class UBlendSpaceLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a blend space context from an anim node context.</summary>
	public static FBlendSpaceReference ConvertToBlendSpace(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a blend space context from an anim node context (pure).</summary>
	public static void ConvertToBlendSpacePure(FAnimNodeReference Node,FBlendSpaceReference BlendSpace,bool Result) {}
	///<summary>Get the current position of the blend space.</summary>
	public static FVector GetPosition(FBlendSpaceReference BlendSpace) { return default; }
	///<summary>Get the current sample coordinates after going through the filtering.</summary>
	public static FVector GetFilteredPosition(FBlendSpaceReference BlendSpace) { return default; }
	///<summary>Forces the Position to the specified value</summary>
	public static void SnapToPosition(FBlendSpaceReference BlendSpace,FVector NewPosition) {}
}
