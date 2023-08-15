namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the attribute/property of a point given its index. The result will be in a ParamData.</summary>
[CppInclude("Elements/PCGAttributeGetFromPointIndexElement.h")]
public partial class UPCGAttributeGetFromPointIndexSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource</summary>
	public FPCGAttributePropertySelector InputSource;
	///<summary>Index</summary>
	public int Index;
	///<summary>OutputAttributeName</summary>
	public FName OutputAttributeName;
	///<summary>InputAttributeName_DEPRECATED</summary>
	public FName InputAttributeName_DEPRECATED;
}
