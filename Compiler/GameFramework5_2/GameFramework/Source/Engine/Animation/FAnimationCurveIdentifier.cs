#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-friendly structure for identifying an animation curve.</summary>
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
public partial struct FAnimationCurveIdentifier {
	public FSmartName InternalName;
	public ERawCurveTrackTypes CurveType;
	public ETransformCurveChannel Channel;
	public EVectorCurveChannel Axis;
}
