#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeAssignment.h")]
public partial class UNiagaraNodeAssignment : UNiagaraNodeFunctionCall {
	///<summary>AssignmentTarget_DEPRECATED</summary>
	public FNiagaraVariable AssignmentTarget_DEPRECATED;
	///<summary>AssignmentDefaultValue_DEPRECATED</summary>
	public string AssignmentDefaultValue_DEPRECATED;
	///<summary>AssignmentTargets</summary>
	public TArray<FNiagaraVariable> AssignmentTargets;
	///<summary>AssignmentDefaultValues</summary>
	public TArray<string> AssignmentDefaultValues;
	///<summary>OldFunctionCallName</summary>
	public string OldFunctionCallName;
}
