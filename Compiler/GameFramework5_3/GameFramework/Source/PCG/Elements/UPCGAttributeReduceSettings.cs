namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take all the entries/points from the input and perform a reduce operation on the given attribute/property</summary>
[CppInclude("Elements/PCGAttributeReduceElement.h")]
public partial class UPCGAttributeReduceSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource</summary>
	public FPCGAttributePropertyInputSelector InputSource;
	///<summary>OutputAttributeName</summary>
	public FName OutputAttributeName;
	///<summary>Operation</summary>
	public EPCGAttributeReduceOperation Operation;
	///<summary>InputAttributeName_DEPRECATED</summary>
	public FName InputAttributeName_DEPRECATED;
}
