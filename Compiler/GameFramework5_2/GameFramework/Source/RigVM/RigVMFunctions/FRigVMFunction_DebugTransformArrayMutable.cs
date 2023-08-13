namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Debug/RigVMFunction_DebugTransform.h")]
public partial struct FRigVMFunction_DebugTransformArrayMutable {
	public TArray<FTransform> Transforms;
	public ERigUnitDebugTransformMode Mode;
	public FLinearColor Color;
	public float Thickness;
	public float Scale;
	public string Space;
	public FTransform WorldOffset;
	public bool bEnabled;
	public FRigVMFunction_DebugTransformArrayMutable_WorkData WorkData;
}
