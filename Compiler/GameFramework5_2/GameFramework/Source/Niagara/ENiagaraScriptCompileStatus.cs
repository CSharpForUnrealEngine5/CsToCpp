#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Enumerates states a Niagara script can be in.</summary>
public enum ENiagaraScriptCompileStatus {
	NCS_Unknown=0,
	NCS_Dirty=1,
	NCS_Error=2,
	NCS_UpToDate=3,
	NCS_BeingCreated=4,
	NCS_UpToDateWithWarnings=5,
	NCS_ComputeUpToDateWithWarnings=6,
	NCS_MAX=7,
}
