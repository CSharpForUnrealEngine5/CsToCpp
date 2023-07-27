#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
///<summary>The input device subsystem provides an interface to allow users to set Input Device Properties</summary>
public partial class UInputDeviceSubsystem : UEngineSubsystem {
// InputDeviceSubsystem
	public  FInputDevicePropertyHandle ActivateDevicePropertyOfClass(UClass PropertyClass,FActivateDevicePropertyParams Params) { return default; }
	public  UInputDeviceProperty GetActiveDeviceProperty(FInputDevicePropertyHandle Handle) { return default; }
	public  bool IsPropertyActive(FInputDevicePropertyHandle Handle) { return default; }
	public  void RemoveDevicePropertyByHandle(FInputDevicePropertyHandle HandleToRemove) {}
	public  void RemoveDevicePropertyHandles(TSet<FInputDevicePropertyHandle> HandlesToRemove) {}
	public  void RemoveAllDeviceProperties() {}
	public  FHardwareDeviceIdentifier GetMostRecentlyUsedHardwareDevice(FPlatformUserId InUserId) { return default; }
	public  FHardwareDeviceIdentifier GetInputDeviceHardwareIdentifier(FInputDeviceId InputDevice) { return default; }
	public FHardwareInputDeviceChanged OnInputHardwareDeviceChanged;
	public TSet<FActiveDeviceProperty> ActiveProperties;
	public TSet<FInputDevicePropertyHandle> PropertiesPendingRemoval;
}
