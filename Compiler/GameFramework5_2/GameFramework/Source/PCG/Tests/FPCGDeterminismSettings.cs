namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismSettings.h")]
public partial struct FPCGDeterminismSettings {
	public bool bNativeTests;
	public bool bUseBlueprintDeterminismTest;
	public UClass DeterminismTestBlueprint;
}
