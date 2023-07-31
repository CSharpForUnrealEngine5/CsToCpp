#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LineBatchComponent.h")]
public partial struct FBatchedLine {
	public FVector Start;
	public FVector End;
	public FLinearColor Color;
	public float Thickness;
	public float RemainingLifeTime;
	public byte DepthPriority;
}
