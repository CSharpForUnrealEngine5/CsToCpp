namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
public enum EARTrackingQualityReason {
	None=0,
	Initializing=1,
	Relocalizing=2,
	ExcessiveMotion=3,
	InsufficientFeatures=4,
	InsufficientLight=5,
	BadState=6,
}
