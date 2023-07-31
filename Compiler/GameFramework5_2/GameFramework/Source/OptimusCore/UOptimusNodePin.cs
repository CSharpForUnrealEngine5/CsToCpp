#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodePin.h")]
public partial class UOptimusNodePin : UObject {
	///<summary>bIsGroupingPin</summary>
	public bool bIsGroupingPin;
	///<summary>Direction</summary>
	public EOptimusNodePinDirection Direction;
	///<summary>StorageType_DEPRECATED</summary>
	public EOptimusNodePinStorageType StorageType_DEPRECATED;
	///<summary>DataDomain</summary>
	public FOptimusDataDomain DataDomain;
	///<summary>DataType</summary>
	public FOptimusDataTypeRef DataType;
	///<summary>SubPins</summary>
	public TArray<UOptimusNodePin> SubPins;
}
