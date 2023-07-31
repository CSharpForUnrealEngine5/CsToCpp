#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/SlateEnums.h")]
///<summary>Enumerates different methods that a button can be triggered with keyboard/controller. Normally, DownAndUp is appropriate.</summary>
[CppEnumInNamespace]
public enum EButtonPressMethod {
	DownAndUp=0,
	ButtonPress=1,
	ButtonRelease=2,
}
