namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerTypes.h")]
public partial struct FGameplayDebuggerShape {
	public TArray<FVector> ShapeData;
	public string Description;
	public FColor Color;
	public EGameplayDebuggerShape Type;
}
