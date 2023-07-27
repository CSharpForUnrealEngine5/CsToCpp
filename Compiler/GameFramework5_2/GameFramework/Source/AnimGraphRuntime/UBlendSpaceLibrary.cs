#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpaceLibrary.h")]
///<summary>Exposes operations to be performed on a blend space anim node.</summary>
public partial class UBlendSpaceLibrary : UBlueprintFunctionLibrary {
// BlendSpaceLibrary
	public static FBlendSpaceReference ConvertToBlendSpace(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToBlendSpacePure(FAnimNodeReference Node,FBlendSpaceReference BlendSpace,bool Result) {}
	public static FVector GetPosition(FBlendSpaceReference BlendSpace) { return default; }
	public static FVector GetFilteredPosition(FBlendSpaceReference BlendSpace) { return default; }
	public static void SnapToPosition(FBlendSpaceReference BlendSpace,FVector NewPosition) {}
}
