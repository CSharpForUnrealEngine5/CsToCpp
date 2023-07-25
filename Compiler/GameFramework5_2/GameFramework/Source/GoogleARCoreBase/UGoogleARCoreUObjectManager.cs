#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreAPI.h")]
public partial class UGoogleARCoreUObjectManager : UObject {
// GoogleARCoreUObjectManager
	public UGoogleARCorePointCloud LatestPointCloud;
	public TMap<FARCorePointer,FTrackedGeometryGroup> TrackableHandleMap;
	public TMap<FARCorePointer,UARPin> HandleToAnchorMap;
}
