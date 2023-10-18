namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserInterfaceSettings.h")]
///<summary>When to render the Focus Brush for widgets that have user focus. Based on the EFocusCause.</summary>
public enum ERenderFocusRule {
	Always=0,
	NonPointer=1,
	NavigationOnly=2,
	Never=3,
}
