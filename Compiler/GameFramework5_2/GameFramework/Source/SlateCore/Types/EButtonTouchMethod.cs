#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/SlateEnums.h")]
///<summary>Ways in which touch interactions trigger a "Clicked" event.</summary>
[CppEnumInNamespace]
public enum EButtonTouchMethod {
	DownAndUp=0,
	Down=1,
	PreciseTap=2,
}
