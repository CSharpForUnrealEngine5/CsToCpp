namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for powering on a target device.</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceServicePowerOff {
	public bool Force;
	public string Operator;
}
