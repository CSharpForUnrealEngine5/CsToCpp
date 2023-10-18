namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Defines modes for updating the component&#39;s age.</summary>
public enum ENiagaraAgeUpdateMode {
	TickDeltaTime=0,
	DesiredAge=1,
	DesiredAgeNoSeek=2,
}
