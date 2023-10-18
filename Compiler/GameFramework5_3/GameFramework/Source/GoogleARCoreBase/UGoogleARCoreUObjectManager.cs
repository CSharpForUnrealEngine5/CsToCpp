namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreAPI.h")]
public partial class UGoogleARCoreUObjectManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LatestPointCloud</summary>
	public UGoogleARCorePointCloud LatestPointCloud;
	///<summary>pointer type is ArTrackable*</summary>
	public TMap<FARCorePointer,FTrackedGeometryGroup> TrackableHandleMap;
	///<summary>pointer type is ArAnchor*</summary>
	public TMap<FARCorePointer,UARPin> HandleToAnchorMap;
}
