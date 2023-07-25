#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Flags that apply to a destructible actor.</summary>
public partial struct FDestructibleParametersFlag {
// DestructibleParametersFlag
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
