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
