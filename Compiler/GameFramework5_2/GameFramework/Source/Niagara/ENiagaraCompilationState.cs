namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraAsyncCompile.h")]
public enum ENiagaraCompilationState {
	CheckDDC=0,
	Precompile=1,
	StartCompileJob=2,
	AwaitResult=3,
	OptimizeByteCode=4,
	ProcessResult=5,
	PutToDDC=6,
	Finished=7,
	Aborted=8,
}
