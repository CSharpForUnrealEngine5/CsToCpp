#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
///<summary>Keeps a saved location and the name of that location</summary>
public partial struct FVirtualCameraWaypoint {
// VirtualCameraWaypoint
	public string Name;
	public FTransform WaypointTransform;
	public FDateTime DateCreated;
	public bool bIsHomeWaypoint;
	public bool bIsFavorited;
}
