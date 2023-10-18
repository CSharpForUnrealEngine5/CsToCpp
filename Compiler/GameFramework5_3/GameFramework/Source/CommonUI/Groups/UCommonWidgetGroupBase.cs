namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for CommonUI widget groups, currently only used for button groups</summary>
[CppInclude("Groups/CommonWidgetGroupBase.h")]
public partial class UCommonWidgetGroupBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AddWidget</summary>
	public void AddWidget(UWidget InWidget) {}
	///<summary>RemoveWidget</summary>
	public void RemoveWidget(UWidget InWidget) {}
	///<summary>RemoveAll</summary>
	public void RemoveAll() {}
}
