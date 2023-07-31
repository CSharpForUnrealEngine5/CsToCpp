#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
public partial struct FLidarPointCloudTraceHit {
	public ALidarPointCloudActor Actor;
	public ULidarPointCloudComponent Component;
	public TArray<FLidarPointCloudPoint> Points;
}
