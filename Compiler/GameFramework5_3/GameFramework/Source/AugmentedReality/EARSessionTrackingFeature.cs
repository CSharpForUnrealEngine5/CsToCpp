namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for more tracking features to be enabled for the session, in addition to what is already defined in the project’s @EARSessionType.</summary>
public enum EARSessionTrackingFeature {
	None=0,
	PoseDetection2D=1,
	PersonSegmentation=2,
	PersonSegmentationWithDepth=3,
	SceneDepth=4,
	SmoothedSceneDepth=5,
}
