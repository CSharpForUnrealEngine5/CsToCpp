#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMDrawInstruction.h")]
public partial struct FRigVMDrawInstruction {
// RigVMDrawInstruction
	public string Name;
	public ERigVMDrawSettings PrimitiveType;
	public TArray<FVector> Positions;
	public FLinearColor Color;
	public float Thickness;
	public FTransform Transform;
}
