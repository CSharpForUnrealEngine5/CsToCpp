#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
///<summary>Contains a pointer to an active device property and keeps track of how long it has been evaluated for</summary>
public partial struct FActiveDeviceProperty {
// ActiveDeviceProperty
	public TWeakObjectPtr<UInputDeviceProperty> Property;
}
