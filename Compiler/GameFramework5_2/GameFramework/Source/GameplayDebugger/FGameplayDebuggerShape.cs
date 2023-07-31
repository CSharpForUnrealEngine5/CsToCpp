#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerTypes.h")]
public partial struct FGameplayDebuggerShape {
	public TArray<FVector> ShapeData;
	public string Description;
	public FColor Color;
	public EGameplayDebuggerShape Type;
}
