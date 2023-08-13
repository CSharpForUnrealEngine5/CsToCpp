namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can&#39;t use FCameraFocusSettings since it use a reference to an actor</summary>
[CppInclude("ConcertVirtualCamera.h")]
public partial struct FConcertVirtualCameraCameraFocusData {
	public float ManualFocusDistance;
	public float FocusSmoothingInterpSpeed;
	public bool bSmoothFocusChanges;
}
