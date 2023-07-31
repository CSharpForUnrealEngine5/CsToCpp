#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a pointer to an active device property and keeps track of how long it has been evaluated for</summary>
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
public partial struct FActiveDeviceProperty {
	public TWeakObjectPtr<UInputDeviceProperty> Property;
}
