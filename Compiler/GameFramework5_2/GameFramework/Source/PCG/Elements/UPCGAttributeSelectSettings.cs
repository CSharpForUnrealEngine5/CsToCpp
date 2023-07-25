#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGAttributeSelectElement.h")]
///<summary>Take all the entries/points from the input and perform a select operation on the given attribute/property on the given axis</summary>
public partial class UPCGAttributeSelectSettings : UPCGSettings {
// PCGAttributeSelectSettings
	public FPCGAttributePropertySelector InputSource;
	public string OutputAttributeName;
	public EPCGAttributeSelectOperation Operation;
	public EPCGAttributeSelectAxis Axis;
	public FVector4 CustomAxis;
	public string InputAttributeName_DEPRECATED;
}
