#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentPoolMethodEnum.h")]
public enum ENCPoolMethod {
	None=0,
	AutoRelease=1,
	ManualRelease=2,
	ManualRelease_OnComplete=3,
	FreeInPool=4,
}
