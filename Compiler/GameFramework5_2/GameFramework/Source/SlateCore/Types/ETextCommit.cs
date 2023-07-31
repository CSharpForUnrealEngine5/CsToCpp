#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/SlateEnums.h")]
///<summary>Additional information about a text committal</summary>
[CppEnumInNamespace]
public enum ETextCommit {
	Default=0,
	OnEnter=1,
	OnUserMovedFocus=2,
	OnCleared=3,
}
