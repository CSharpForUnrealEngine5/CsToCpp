#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Receives raw input from input processor (or player controller in user code).</summary>
[CppInclude("Input/VCamPlayerInput.h")]
public partial class UVCamPlayerInput : UEnhancedPlayerInput {
	///<summary>The device settings governing what we do with received input, e.g. filtering depending on input device, logging, etc.</summary>
	public FVCamInputDeviceConfig InputDeviceSettings;
}
