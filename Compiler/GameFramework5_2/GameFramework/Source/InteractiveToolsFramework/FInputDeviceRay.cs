#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputState.h")]
///<summary>FInputDeviceRay represents a 3D ray created based on an input device.</summary>
public partial struct FInputDeviceRay {
// InputDeviceRay
	public FRay WorldRay;
	public bool bHas2D;
	public FVector2D ScreenPosition;
}
