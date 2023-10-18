namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLODTypes.h")]
///<summary>We are not using enum class here because we are doing so many arithmetic operation and comparison on them</summary>
[CppEnumInNamespace]
public enum EMassLOD {
	High=0,
	Medium=1,
	Low=2,
	Off=3,
	Max=4,
}
