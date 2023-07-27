#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpacePlayerLibrary.h")]
///<summary>Exposes operations to be performed on a blend space player anim node.</summary>
public partial class UBlendSpacePlayerLibrary : UBlueprintFunctionLibrary {
// BlendSpacePlayerLibrary
	public static FBlendSpacePlayerReference ConvertToBlendSpacePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToBlendSpacePlayerPure(FAnimNodeReference Node,FBlendSpacePlayerReference BlendSpacePlayer,bool Result) {}
	public static FBlendSpacePlayerReference SetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer,UBlendSpace BlendSpace) { return default; }
	public static FBlendSpacePlayerReference SetBlendSpaceWithInertialBlending(FAnimUpdateContext UpdateContext,FBlendSpacePlayerReference BlendSpacePlayer,UBlendSpace BlendSpace,float BlendTime/*=0.2f*/) { return default; }
	public static FBlendSpacePlayerReference SetResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer,bool bReset) { return default; }
	public static FBlendSpacePlayerReference SetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer,float PlayRate) { return default; }
	public static FBlendSpacePlayerReference SetLoop(FBlendSpacePlayerReference BlendSpacePlayer,bool bLoop) { return default; }
	public static UBlendSpace GetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static FVector GetPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static float GetStartPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static float GetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static bool GetLoop(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static bool ShouldResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public static void SnapToPosition(FBlendSpacePlayerReference BlendSpacePlayer,FVector NewPosition) {}
}
