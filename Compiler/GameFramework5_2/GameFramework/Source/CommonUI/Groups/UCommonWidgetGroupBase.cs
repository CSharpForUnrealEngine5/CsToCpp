#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Groups/CommonWidgetGroupBase.h")]
///<summary>@todo DanH: This is only used for buttons, so ditch the base. Also the vast majority of use cases are native, so it also shouldn't be a UObject</summary>
public partial class UCommonWidgetGroupBase : UObject {
// CommonWidgetGroupBase
	public void AddWidget(UObject InWidget) {}
	public void RemoveWidget(UObject InWidget) {}
	public void RemoveAll() {}
}
