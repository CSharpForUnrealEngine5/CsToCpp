namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take all the entries/points from the input and perform a select operation on the given attribute/property on the given axis</summary>
[CppInclude("Elements/PCGAttributeSelectElement.h")]
public partial class UPCGAttributeSelectSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource</summary>
	public FPCGAttributePropertySelector InputSource;
	///<summary>OutputAttributeName</summary>
	public string OutputAttributeName;
	///<summary>Operation</summary>
	public EPCGAttributeSelectOperation Operation;
	///<summary>Axis</summary>
	public EPCGAttributeSelectAxis Axis;
	///<summary>CustomAxis</summary>
	public FVector4 CustomAxis;
	///<summary>InputAttributeName_DEPRECATED</summary>
	public string InputAttributeName_DEPRECATED;
}
