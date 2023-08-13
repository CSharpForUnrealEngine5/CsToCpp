namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The input device subsystem provides an interface to allow users to set Input Device Properties</summary>
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
public partial class UInputDeviceSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Spawn a new instance of the given device property class and activate it.</summary>
	public FInputDevicePropertyHandle ActivateDevicePropertyOfClass(UClass PropertyClass,FActivateDevicePropertyParams Params) { return default; }
	///<summary>Returns a pointer to the active input device property with the given handle. Returns null if the property doesn&#39;t exist</summary>
	public UInputDeviceProperty GetActiveDeviceProperty(FInputDevicePropertyHandle Handle) { return default; }
	///<summary>Returns true if the property associated with the given handle is currently active, and it is not pending removal</summary>
	public bool IsPropertyActive(FInputDevicePropertyHandle Handle) { return default; }
	///<summary>Remove a single device property based on it&#39;s handle</summary>
	public void RemoveDevicePropertyByHandle(FInputDevicePropertyHandle HandleToRemove) {}
	///<summary>Remove a set of device properties based on their handles.</summary>
	public void RemoveDevicePropertyHandles(TSet<FInputDevicePropertyHandle> HandlesToRemove) {}
	///<summary>Removes all the current Input Device Properties that are active, regardless of the Platform User</summary>
	public void RemoveAllDeviceProperties() {}
	///<summary>Gets the most recently used hardware input device for the given platform user</summary>
	public FHardwareDeviceIdentifier GetMostRecentlyUsedHardwareDevice(FPlatformUserId InUserId) { return default; }
	///<summary>GetInputDeviceHardwareIdentifier</summary>
	public FHardwareDeviceIdentifier GetInputDeviceHardwareIdentifier(FInputDeviceId InputDevice) { return default; }
	///<summary>A delegate that is fired when a platform user changes what Hardware Input device they are using</summary>
	public FHardwareInputDeviceChanged OnInputHardwareDeviceChanged;
	///<summary>Set of currently active input device properties that will be evaluated on tick</summary>
	public TSet<FActiveDeviceProperty> ActiveProperties;
	///<summary>Set of property handles the properties that are currently pending manual removal.</summary>
	public TSet<FInputDevicePropertyHandle> PropertiesPendingRemoval;
}
