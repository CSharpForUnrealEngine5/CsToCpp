#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudShared.h")]
public partial struct FLidarPointCloudPoint {
// LidarPointCloudPoint
	public FVector3f Location;
	public FColor Color;
	public FLidarPointCloudNormal Normal;
	public bool bVisible;
}
