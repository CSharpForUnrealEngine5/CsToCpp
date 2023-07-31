#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/SlateEnums.h")]
///<summary>Enumerates different methods that a button click can be triggered. Normally, DownAndUp is appropriate.</summary>
[CppEnumInNamespace]
public enum EButtonClickMethod {
	DownAndUp=0,
	MouseDown=1,
	MouseUp=2,
	PreciseClick=3,
}
