#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter the attributes from a given input metadata.</summary>
[CppInclude("Elements/PCGAttributeFilterElement.h")]
public partial class UPCGAttributeFilterSettings : UPCGSettings {
	///<summary>Operation</summary>
	public EPCGAttributeFilterOperation Operation;
	///<summary>SelectedAttributes</summary>
	public string SelectedAttributes;
	///<summary>AttributesToKeep_DEPRECATED</summary>
	public TArray<string> AttributesToKeep_DEPRECATED;
}
