#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Harmonics/RigUnit_ChainHarmonics.h")]
public partial struct FRigUnit_ChainHarmonics_WorkData {
	public FVector Time;
	public TArray<FCachedRigElement> Items;
	public TArray<float> Ratio;
	public TArray<FVector> LocalTip;
	public TArray<FVector> PendulumTip;
	public TArray<FVector> PendulumPosition;
	public TArray<FVector> PendulumVelocity;
	public TArray<FVector> HierarchyLine;
	public TArray<FVector> VelocityLines;
}
