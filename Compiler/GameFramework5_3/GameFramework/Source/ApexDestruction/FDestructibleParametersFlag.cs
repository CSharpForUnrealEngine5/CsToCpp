namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Flags that apply to a destructible actor.</summary>
[CppInclude("DestructibleMesh.h")]
public partial struct FDestructibleParametersFlag {
	public bool bAccumulateDamage;
	public bool bAssetDefinedSupport;
	public bool bWorldSupport;
	public bool bDebrisTimeout;
	public bool bDebrisMaxSeparation;
	public bool bCrumbleSmallestChunks;
	public bool bAccurateRaycasts;
	public bool bUseValidBounds;
	public bool bFormExtendedStructures;
}
