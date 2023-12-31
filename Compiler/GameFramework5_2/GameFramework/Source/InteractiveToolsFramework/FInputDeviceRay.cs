namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FInputDeviceRay represents a 3D ray created based on an input device.</summary>
[CppInclude("InputState.h")]
public partial struct FInputDeviceRay {
	public FRay WorldRay;
	public bool bHas2D;
	public FVector2D ScreenPosition;
}
