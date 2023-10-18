namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public enum ENiagaraBindingSource {
	ImplicitFromSource=0,
	ExplicitParticles=1,
	ExplicitEmitter=2,
	ExplicitSystem=3,
	ExplicitUser=4,
	MaxBindingSource=5,
}
