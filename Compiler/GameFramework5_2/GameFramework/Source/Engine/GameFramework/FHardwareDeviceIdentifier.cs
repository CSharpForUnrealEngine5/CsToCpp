namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An identifier that can be used to determine what input devices are available based on the FInputDeviceScope.</summary>
[CppInclude("GameFramework/InputSettings.h")]
public partial struct FHardwareDeviceIdentifier {
	public string InputClassName;
	public string HardwareDeviceIdentifier;
}
