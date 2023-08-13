namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@todo DanH: This is only used for buttons, so ditch the base. Also the vast majority of use cases are native, so it also shouldn&#39;t be a UObject</summary>
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
