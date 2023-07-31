#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filters a data collection based on some tag criterion</summary>
[CppInclude("Elements/PCGFilterByTag.h")]
public partial class UPCGFilterByTagSettings : UPCGSettings {
	///<summary>Operation</summary>
	public EPCGFilterByTagOperation Operation;
	///<summary>Comma-separated list of tags</summary>
	public string SelectedTags;
}
