namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGizmoVec2ParameterChange represents a change in the value of an IGizmoVec2ParameterSource.</summary>
[CppInclude("BaseGizmos/ParameterSourcesVec2.h")]
public partial struct FGizmoVec2ParameterChange {
	public FVector2D InitialValue;
	public FVector2D CurrentValue;
}
