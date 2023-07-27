#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LayeredBoneBlendLibrary.h")]
///<summary>Exposes operations to be performed on a layered bone blend anim node.</summary>
public partial class ULayeredBoneBlendLibrary : UBlueprintFunctionLibrary {
// LayeredBoneBlendLibrary
	public static FLayeredBoneBlendReference ConvertToLayeredBoneBlend(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToLayeredBlendPerBonePure(FAnimNodeReference Node,FLayeredBoneBlendReference LayeredBoneBlend,bool Result) {}
	public static int GetNumPoses(FLayeredBoneBlendReference LayeredBoneBlend) { return default; }
	public static FLayeredBoneBlendReference SetBlendMask(FAnimUpdateContext UpdateContext,FLayeredBoneBlendReference LayeredBoneBlend,int PoseIndex,string BlendMaskName) { return default; }
}
