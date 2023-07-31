#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters that apply to a destructible actor.</summary>
[CppInclude("DestructibleMesh.h")]
public partial struct FDestructibleParameters {
	public FDestructibleDamageParameters DamageParameters;
	public FDestructibleDebrisParameters DebrisParameters;
	public FDestructibleAdvancedParameters AdvancedParameters;
	public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths;
	public TArray<FDestructibleDepthParameters> DepthParameters;
	public FDestructibleParametersFlag Flags;
}
