namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object used to export AnimCurves to clipboard</summary>
[CppInclude("AnimTimeline/AnimTimelineClipboard.h")]
public partial class UAnimCurveBaseCopyObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SmartName Start</summary>
	public FName DisplayName;
	///<summary>UID</summary>
	public ushort UID;
	///<summary>SmartName End</summary>
	public ERawCurveTrackTypes CurveType;
	///<summary>Channel</summary>
	public ETransformCurveChannel Channel;
	///<summary>Axis</summary>
	public EVectorCurveChannel Axis;
	///<summary>This curve&#39;s data owner name (ex. UAnimSequenceBase Name), if any. Used internally to check if the user is attempting to paste curve data into source curve.</summary>
	public FName OriginName;
}
