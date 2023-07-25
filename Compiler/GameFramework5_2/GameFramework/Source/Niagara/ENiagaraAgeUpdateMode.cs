#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Defines modes for updating the component's age.</summary>
public enum ENiagaraAgeUpdateMode {
	TickDeltaTime=0,
	DesiredAge=1,
	DesiredAgeNoSeek=2,
}
