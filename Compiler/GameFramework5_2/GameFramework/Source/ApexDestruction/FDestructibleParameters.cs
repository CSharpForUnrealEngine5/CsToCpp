#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Parameters that apply to a destructible actor.</summary>
public partial struct FDestructibleParameters {
// DestructibleParameters
	public FDestructibleDamageParameters DamageParameters;
	public FDestructibleDebrisParameters DebrisParameters;
	public FDestructibleAdvancedParameters AdvancedParameters;
	public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths;
	public TArray<FDestructibleDepthParameters> DepthParameters;
	public FDestructibleParametersFlag Flags;
}
