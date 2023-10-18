namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Defines different usages for a niagara script&#39;s module dependecies.</summary>
public enum ENiagaraModuleDependencyUsage {
	None=0,
	Spawn=1,
	Update=2,
	Event=3,
	SimulationStage=4,
}
