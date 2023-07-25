#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertVirtualCamera.h")]
///<summary>Can't use FCameraFocusSettings since it use a reference to an actor</summary>
public partial struct FConcertVirtualCameraCameraFocusData {
// ConcertVirtualCameraCameraFocusData
	public float ManualFocusDistance;
	public float FocusSmoothingInterpSpeed;
	public bool bSmoothFocusChanges;
}
