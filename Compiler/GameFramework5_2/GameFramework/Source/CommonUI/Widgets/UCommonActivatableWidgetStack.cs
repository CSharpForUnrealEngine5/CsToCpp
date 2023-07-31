#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A display stack of ActivatableWidget elements.</summary>
[CppInclude("Widgets/CommonActivatableWidgetContainer.h")]
public partial class UCommonActivatableWidgetStack : UCommonActivatableWidgetContainerBase {
	///<summary>Optional widget to auto-generate as the permanent root element of the stack</summary>
	public UClass RootContentWidgetClass;
	///<summary>RootContentWidget</summary>
	public UCommonActivatableWidget RootContentWidget;
}
