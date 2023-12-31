namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A display stack of ActivatableWidget elements.</summary>
[CppInclude("Widgets/CommonActivatableWidgetContainer.h")]
public partial class UCommonActivatableWidgetStack : UCommonActivatableWidgetContainerBase {
	public static UClass StaticClass() {return default;}
	///<summary>Optional widget to auto-generate as the permanent root element of the stack</summary>
	public UClass RootContentWidgetClass;
	///<summary>RootContentWidget</summary>
	public UCommonActivatableWidget RootContentWidget;
}
