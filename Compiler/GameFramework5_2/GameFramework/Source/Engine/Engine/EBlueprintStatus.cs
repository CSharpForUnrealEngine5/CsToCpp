#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Enumerates states a blueprint can be in.</summary>
public enum EBlueprintStatus {
	BS_Unknown=0,
	BS_Dirty=1,
	BS_Error=2,
	BS_UpToDate=3,
	BS_BeingCreated=4,
	BS_UpToDateWithWarnings=5,
	BS_MAX=6,
}
