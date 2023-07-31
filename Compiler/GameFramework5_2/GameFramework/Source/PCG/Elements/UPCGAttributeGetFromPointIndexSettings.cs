#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the attribute/property of a point given its index. The result will be in a ParamData.</summary>
[CppInclude("Elements/PCGAttributeGetFromPointIndexElement.h")]
public partial class UPCGAttributeGetFromPointIndexSettings : UPCGSettings {
	///<summary>InputSource</summary>
	public FPCGAttributePropertySelector InputSource;
	///<summary>Index</summary>
	public int Index;
	///<summary>OutputAttributeName</summary>
	public string OutputAttributeName;
	///<summary>InputAttributeName_DEPRECATED</summary>
	public string InputAttributeName_DEPRECATED;
}
