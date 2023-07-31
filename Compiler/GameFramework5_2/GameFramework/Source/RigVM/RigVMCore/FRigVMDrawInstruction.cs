#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMDrawInstruction.h")]
public partial struct FRigVMDrawInstruction {
	public string Name;
	public ERigVMDrawSettings PrimitiveType;
	public TArray<FVector> Positions;
	public FLinearColor Color;
	public float Thickness;
	public FTransform Transform;
}
