namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMDrawInstruction.h")]
public partial struct FRigVMDrawInstruction {
	public FName Name;
	public ERigVMDrawSettings PrimitiveType;
	public TArray<FVector> Positions;
	public FLinearColor Color;
	public float Thickness;
	public FTransform Transform;
}
