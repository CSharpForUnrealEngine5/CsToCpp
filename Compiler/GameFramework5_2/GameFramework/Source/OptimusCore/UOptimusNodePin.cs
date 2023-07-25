#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodePin.h")]
public partial class UOptimusNodePin : UObject {
// OptimusNodePin
	public bool bIsGroupingPin;
	public EOptimusNodePinDirection Direction;
	public EOptimusNodePinStorageType StorageType_DEPRECATED;
	public FOptimusDataDomain DataDomain;
	public FOptimusDataTypeRef DataType;
	public TArray<UOptimusNodePin> SubPins;
}
