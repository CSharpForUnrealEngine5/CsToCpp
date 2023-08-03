#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The trait initializes the entity with actor capsule component&#39;s radius. In addition, if bSyncTransform is true</summary>
[CppInclude("MassAgentTraits.h")]
public partial class UMassAgentCapsuleCollisionSyncTrait : UMassAgentSyncTrait {
	public static UClass StaticClass() {return default;}
	///<summary>bSyncTransform</summary>
	public bool bSyncTransform;
}
