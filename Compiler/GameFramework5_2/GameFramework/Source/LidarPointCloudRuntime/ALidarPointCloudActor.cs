#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudActor.h")]
public partial class ALidarPointCloudActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PointCloudComponent</summary>
	public ULidarPointCloudComponent PointCloudComponent;
	///<summary>GetPointCloud</summary>
	public  ULidarPointCloud GetPointCloud() { return default; }
	///<summary>SetPointCloud</summary>
	public  void SetPointCloud(ULidarPointCloud InPointCloud) {}
}
