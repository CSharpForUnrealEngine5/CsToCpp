namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public enum ENiagaraGpuSyncMode {
	None=0,
	SyncCpuToGpu=1,
	SyncGpuToCpu=2,
	SyncBoth=3,
}
