#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data required for setting the Input Device Color</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial struct FDeviceColorCurveData {
	public bool bEnable;
	public bool bResetAfterCompletion;
	public UCurveLinearColor DeviceColorCurve;
}
