namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-friendly structure for identifying an animation curve.</summary>
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
public partial struct FAnimationCurveIdentifier {
	public FSmartName InternalName_DEPRECATED;
	public FName CurveName;
	public ERawCurveTrackTypes CurveType;
	public ETransformCurveChannel Channel;
	public EVectorCurveChannel Axis;
}
