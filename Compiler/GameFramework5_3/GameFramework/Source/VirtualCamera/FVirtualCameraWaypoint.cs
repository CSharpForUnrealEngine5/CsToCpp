namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps a saved location and the name of that location</summary>
[CppInclude("VirtualCameraSaveGame.h")]
public partial struct FVirtualCameraWaypoint {
	public string Name;
	public FTransform WaypointTransform;
	public FDateTime DateCreated;
	public bool bIsHomeWaypoint;
	public bool bIsFavorited;
}
