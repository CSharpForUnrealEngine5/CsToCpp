#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take all the entries/points from the input and perform a reduce operation on the given attribute/property</summary>
[CppInclude("Elements/PCGAttributeReduceElement.h")]
public partial class UPCGAttributeReduceSettings : UPCGSettings {
	///<summary>InputSource</summary>
	public FPCGAttributePropertySelector InputSource;
	///<summary>OutputAttributeName</summary>
	public string OutputAttributeName;
	///<summary>Operation</summary>
	public EPCGAttributeReduceOperation Operation;
	///<summary>InputAttributeName_DEPRECATED</summary>
	public string InputAttributeName_DEPRECATED;
}
