#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
///<summary>Script-friendly structure for identifying an animation curve.</summary>
public partial struct FAnimationCurveIdentifier {
// AnimationCurveIdentifier
	public FSmartName InternalName;
	public ERawCurveTrackTypes CurveType;
	public ETransformCurveChannel Channel;
	public EVectorCurveChannel Axis;
}
