#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreamingVolume.h")]
///<summary>Enum for different usage cases of level streaming volumes.</summary>
public enum EStreamingVolumeUsage {
	SVB_Loading=0,
	SVB_LoadingAndVisibility=1,
	SVB_VisibilityBlockingOnLoad=2,
	SVB_BlockingOnLoad=3,
	SVB_LoadingNotVisible=4,
	SVB_MAX=5,
}
