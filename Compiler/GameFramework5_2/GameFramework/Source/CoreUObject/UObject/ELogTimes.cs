namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Enum that defines how the log times are to be displayed.</summary>
[CppEnumInNamespace]
public enum ELogTimes {
	None=0,
	UTC=1,
	SinceGStartTime=2,
	Local=3,
}
