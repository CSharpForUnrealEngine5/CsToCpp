#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/Events.h")]
///<summary>Context for focus change</summary>
public enum EFocusCause {
	Mouse=0,
	Navigation=1,
	SetDirectly=2,
	Cleared=3,
	OtherWidgetLostFocus=4,
	WindowActivate=5,
}
