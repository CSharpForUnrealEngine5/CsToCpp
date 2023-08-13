namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial struct FPCGPinProperties {
	public string Label;
	public EPCGDataType AllowedTypes;
	public bool bAllowMultipleData;
	public bool bAllowMultipleConnections;
	public bool bAdvancedPin;
	public FText Tooltip;
}
