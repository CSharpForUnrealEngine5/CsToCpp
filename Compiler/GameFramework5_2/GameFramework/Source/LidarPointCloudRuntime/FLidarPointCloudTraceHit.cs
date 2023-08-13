namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloud.h")]
public partial struct FLidarPointCloudTraceHit {
	public ALidarPointCloudActor Actor;
	public ULidarPointCloudComponent Component;
	public TArray<FLidarPointCloudPoint> Points;
}
