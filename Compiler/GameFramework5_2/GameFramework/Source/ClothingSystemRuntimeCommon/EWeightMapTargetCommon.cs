#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PointWeightMap.h")]
///<summary>The possible targets for a physical mesh point weight map.</summary>
public enum EWeightMapTargetCommon {
	None=0,
	MaxDistance=1,
	BackstopDistance=2,
	BackstopRadius=3,
	AnimDriveStiffness=4,
	AnimDriveDamping_DEPRECATED=5,
}
