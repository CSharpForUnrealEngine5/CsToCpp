#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimTimeline/AnimTimelineClipboard.h")]
///<summary>Object used to export AnimCurves to clipboard</summary>
public partial class UAnimCurveBaseCopyObject : UObject {
// AnimCurveBaseCopyObject
	public string DisplayName;
	public ushort UID;
	public ERawCurveTrackTypes CurveType;
	public ETransformCurveChannel Channel;
	public EVectorCurveChannel Axis;
	public string OriginName;
}
