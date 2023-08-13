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
