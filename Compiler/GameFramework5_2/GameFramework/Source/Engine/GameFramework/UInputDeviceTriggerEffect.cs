namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A property that effect the triggers on a gamepad</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceTriggerEffect : UInputDeviceProperty {
	public static UClass StaticClass() {return default;}
	///<summary>BaseTriggerData</summary>
	public FDeviceTriggerBaseData BaseTriggerData;
}
