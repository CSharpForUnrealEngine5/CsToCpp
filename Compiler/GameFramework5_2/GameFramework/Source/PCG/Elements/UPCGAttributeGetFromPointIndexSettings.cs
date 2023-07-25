#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGAttributeGetFromPointIndexElement.h")]
///<summary>Get the attribute/property of a point given its index. The result will be in a ParamData.</summary>
public partial class UPCGAttributeGetFromPointIndexSettings : UPCGSettings {
// PCGAttributeGetFromPointIndexSettings
	public FPCGAttributePropertySelector InputSource;
	public int Index;
	public string OutputAttributeName;
	public string InputAttributeName_DEPRECATED;
}
