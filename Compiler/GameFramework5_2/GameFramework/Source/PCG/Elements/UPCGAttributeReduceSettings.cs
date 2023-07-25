#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGAttributeReduceElement.h")]
///<summary>Take all the entries/points from the input and perform a reduce operation on the given attribute/property</summary>
public partial class UPCGAttributeReduceSettings : UPCGSettings {
// PCGAttributeReduceSettings
	public FPCGAttributePropertySelector InputSource;
	public string OutputAttributeName;
	public EPCGAttributeReduceOperation Operation;
	public string InputAttributeName_DEPRECATED;
}
