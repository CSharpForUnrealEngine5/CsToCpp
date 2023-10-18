namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudShared.h")]
public partial struct FLidarPointCloudPoint {
	public FVector3f Location;
	public FColor Color;
	public FLidarPointCloudNormal Normal;
	public bool bVisible;
}
