namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetInteractionComponent.h")]
///<summary>The interaction source for the widget interaction component, e.g. where do we try and</summary>
public enum EWidgetInteractionSource {
	World=0,
	Mouse=1,
	CenterScreen=2,
	Custom=3,
}
