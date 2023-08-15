namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@TODO: Add comments/tooltips.</summary>
[CppInclude("AnimationModifiers/OrientationWarpingModifier.h")]
public partial class UOrientationWarpingModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>EnableWarpingCurveName</summary>
	public FName EnableWarpingCurveName;
	///<summary>EnableOffsetCurveName</summary>
	public FName EnableOffsetCurveName;
	///<summary>BlendInTime</summary>
	public float BlendInTime;
	///<summary>BlendOutTime</summary>
	public float BlendOutTime;
	///<summary>StopSpeedThreshold</summary>
	public float StopSpeedThreshold;
}
