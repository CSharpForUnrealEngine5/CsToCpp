#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpacePlayerLibrary.h")]
///<summary>Exposes operations to be performed on a blend space player anim node.</summary>
public partial class UBlendSpacePlayerLibrary : UBlueprintFunctionLibrary {
// BlendSpacePlayerLibrary
	public FBlendSpacePlayerReference ConvertToBlendSpacePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public void ConvertToBlendSpacePlayerPure(FAnimNodeReference Node,FBlendSpacePlayerReference BlendSpacePlayer,bool Result) {}
	public FBlendSpacePlayerReference SetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer,UObject BlendSpace) { return default; }
	public FBlendSpacePlayerReference SetBlendSpaceWithInertialBlending(FAnimUpdateContext UpdateContext,FBlendSpacePlayerReference BlendSpacePlayer,UObject BlendSpace,float BlendTime/*=0.2f*/) { return default; }
	public FBlendSpacePlayerReference SetResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer,bool bReset) { return default; }
	public FBlendSpacePlayerReference SetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer,float PlayRate) { return default; }
	public FBlendSpacePlayerReference SetLoop(FBlendSpacePlayerReference BlendSpacePlayer,bool bLoop) { return default; }
	public UObject GetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public FVector GetPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public float GetStartPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public float GetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public bool GetLoop(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public bool ShouldResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	public void SnapToPosition(FBlendSpacePlayerReference BlendSpacePlayer,FVector NewPosition) {}
}
