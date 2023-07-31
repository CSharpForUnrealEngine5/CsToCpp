#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AITypes.h")]
[CppEnumInNamespace]
public enum EPawnActionResult {
	NotStarted=0,
	InProgress=1,
	Success=2,
	Failed=3,
	Aborted=4,
}
