#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableGameplayComponent.h")]
public partial struct FRigBoundRayCasts {
// RigBoundRayCasts
	public bool bEnableRigBoundRaycasts;
	public int MaxNumTests;
	public bool bTestDownOnly;
	public float TestRange;
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> EnvironmentCollisionsSkipList;
	public byte CollisionChannel;
}
