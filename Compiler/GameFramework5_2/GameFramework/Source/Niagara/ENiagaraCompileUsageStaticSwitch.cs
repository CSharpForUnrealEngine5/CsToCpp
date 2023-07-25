#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Defines different usages for a niagara script.</summary>
public enum ENiagaraCompileUsageStaticSwitch {
	Spawn=0,
	Update=1,
	Event=2,
	SimulationStage=3,
	Default=4,
}
