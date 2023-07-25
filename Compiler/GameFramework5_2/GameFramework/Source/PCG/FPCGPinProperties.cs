#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial struct FPCGPinProperties {
// PCGPinProperties
	public string Label;
	public EPCGDataType AllowedTypes;
	public bool bAllowMultipleData;
	public bool bAllowMultipleConnections;
	public bool bAdvancedPin;
	public string Tooltip;
}
