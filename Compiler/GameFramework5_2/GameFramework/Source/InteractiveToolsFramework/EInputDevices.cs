#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputState.h")]
///<summary>Input event data can be applicable to many possible input devices.</summary>
public enum EInputDevices {
	None=0,
	Keyboard=1,
	Mouse=2,
	Gamepad=4,
	OculusTouch=8,
	HTCViveWands=16,
	AnySpatialDevice=-1,
	TabletFingers=1024,
}
