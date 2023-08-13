namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ProjectPackagingSettings.h")]
///<summary>Enumerates the available build configurations for project packaging.</summary>
public enum EProjectPackagingBuildConfigurations {
	PPBC_Debug=0,
	PPBC_DebugGame=1,
	PPBC_Development=2,
	PPBC_Test=3,
	PPBC_Shipping=4,
	PPBC_MAX=5,
}
