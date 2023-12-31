namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Receives raw input from input processor (or player controller in user code).</summary>
[CppInclude("Input/VCamPlayerInput.h")]
public partial class UVCamPlayerInput : UEnhancedPlayerInput {
	public static UClass StaticClass() {return default;}
	///<summary>The device settings governing what we do with received input, e.g. filtering depending on input device, logging, etc.</summary>
	public FVCamInputDeviceConfig InputDeviceSettings;
}
