namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URootMotionModifier_Scale</summary>
[CppInclude("RootMotionModifier.h")]
public partial class URootMotionModifier_Scale : URootMotionModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Vector used to scale each component of the translation</summary>
	public FVector Scale;
	///<summary>AddRootMotionModifierScale</summary>
	public static URootMotionModifier_Scale AddRootMotionModifierScale(UMotionWarpingComponent InMotionWarpingComp,UAnimSequenceBase InAnimation,float InStartTime,float InEndTime,FVector InScale/*=new FVector(1.0f)*/) { return default; }
}
