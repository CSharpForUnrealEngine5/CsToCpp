#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
///<summary>The source from which a script execution state was set. Used to allow scalability etc to change the state but only if the state has not been defined by something with higher precedence.</summary>
public enum ENiagaraExecutionStateSource {
	Scalability=0,
	Internal=1,
	Owner=2,
	InternalCompletion=3,
}
