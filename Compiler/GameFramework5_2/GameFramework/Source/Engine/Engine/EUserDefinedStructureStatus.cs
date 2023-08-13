namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserDefinedStruct.h")]
public enum EUserDefinedStructureStatus {
	UDSS_UpToDate=0,
	UDSS_Dirty=1,
	UDSS_Error=2,
	UDSS_Duplicate=3,
	UDSS_MAX=4,
}
