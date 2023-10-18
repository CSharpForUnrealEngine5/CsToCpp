namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filters a data collection based on some tag criterion</summary>
[CppInclude("Elements/PCGFilterByTag.h")]
public partial class UPCGFilterByTagSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Operation</summary>
	public EPCGFilterByTagOperation Operation;
	///<summary>Comma-separated list of tags</summary>
	public string SelectedTags;
}
