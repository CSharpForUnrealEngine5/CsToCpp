namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_DebugLineStrip.h")]
public partial struct FRigUnit_DebugLineStrip {
	public TArray<FVector> Points;
	public FLinearColor Color;
	public float Thickness;
	public FName Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
