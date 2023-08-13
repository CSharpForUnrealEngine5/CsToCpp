namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassLODTrait.h")]
public partial class UMassSimulationLODTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Params</summary>
	public FMassSimulationLODParameters Params;
	///<summary>bEnableVariableTicking</summary>
	public bool bEnableVariableTicking;
	///<summary>VariableTickParams</summary>
	public FMassSimulationVariableTickParameters VariableTickParams;
}
