namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cached camera POV info, stored as optimization so we only</summary>
[CppInclude("Camera/PlayerCameraManager.h")]
public partial struct FCameraCacheEntry {
	public float TimeStamp;
	public FMinimalViewInfo POV;
}
