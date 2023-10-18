namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for the tracking type of the session. All AR platforms use this structure but only some session tracking are supported on each platform. The options are mutually exclusive.</summary>
public enum EARSessionType {
	None=0,
	Orientation=1,
	World=2,
	Face=3,
	Image=4,
	ObjectScanning=5,
	PoseTracking=6,
	GeoTracking=7,
}
