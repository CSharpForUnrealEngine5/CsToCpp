namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a blend space player anim node.</summary>
[CppInclude("BlendSpacePlayerLibrary.h")]
public partial class UBlendSpacePlayerLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a blend space player context from an anim node context.</summary>
	public static FBlendSpacePlayerReference ConvertToBlendSpacePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a blend space player context from an anim node context (pure).</summary>
	public static void ConvertToBlendSpacePlayerPure(FAnimNodeReference Node,FBlendSpacePlayerReference BlendSpacePlayer,bool Result) {}
	///<summary>Set the current BlendSpace of the blend space player.</summary>
	public static FBlendSpacePlayerReference SetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer,UBlendSpace BlendSpace) { return default; }
	///<summary>Set the current BlendSpace of the blend space player with an interial blend time.</summary>
	public static FBlendSpacePlayerReference SetBlendSpaceWithInertialBlending(FAnimUpdateContext UpdateContext,FBlendSpacePlayerReference BlendSpacePlayer,UBlendSpace BlendSpace,float BlendTime/*=0.2f*/) { return default; }
	///<summary>Set whether the current play time should reset when BlendSpace changes of the blend space player.</summary>
	public static FBlendSpacePlayerReference SetResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer,bool bReset) { return default; }
	///<summary>Set the play rate of the blend space player.</summary>
	public static FBlendSpacePlayerReference SetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer,float PlayRate) { return default; }
	///<summary>Set the loop of the blend space player.</summary>
	public static FBlendSpacePlayerReference SetLoop(FBlendSpacePlayerReference BlendSpacePlayer,bool bLoop) { return default; }
	///<summary>Get the current BlendSpace of the blend space player.</summary>
	public static UBlendSpace GetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Get the current position of the blend space player.</summary>
	public static FVector GetPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Get the current start position of the blend space player.</summary>
	public static float GetStartPosition(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Get the current play rate of the blend space player.</summary>
	public static float GetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Get the current loop of the blend space player.</summary>
	public static bool GetLoop(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Get the current value of whether the current play time should reset when BlendSpace changes of the blend space player.</summary>
	public static bool ShouldResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer) { return default; }
	///<summary>Forces the Position to the specified value</summary>
	public static void SnapToPosition(FBlendSpacePlayerReference BlendSpacePlayer,FVector NewPosition) {}
}
