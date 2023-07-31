#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreAPI.h")]
public partial class UGoogleARCoreUObjectManager : UObject {
	///<summary>LatestPointCloud</summary>
	public UGoogleARCorePointCloud LatestPointCloud;
	///<summary>pointer type is ArTrackable*</summary>
	public TMap<FARCorePointer,FTrackedGeometryGroup> TrackableHandleMap;
	///<summary>pointer type is ArAnchor*</summary>
	public TMap<FARCorePointer,UARPin> HandleToAnchorMap;
}
