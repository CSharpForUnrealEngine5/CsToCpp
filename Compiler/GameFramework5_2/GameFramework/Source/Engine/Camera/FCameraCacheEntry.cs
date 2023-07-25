#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/PlayerCameraManager.h")]
///<summary>Cached camera POV info, stored as optimization so we only</summary>
public partial struct FCameraCacheEntry {
// CameraCacheEntry
	public float TimeStamp;
	public FMinimalViewInfo POV;
}
