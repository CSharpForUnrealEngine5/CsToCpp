namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableGameplayComponent.h")]
public partial struct FRigBoundRayCasts {
	public bool bEnableRigBoundRaycasts;
	public int MaxNumTests;
	public bool bTestDownOnly;
	public float TestRange;
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> EnvironmentCollisionsSkipList;
	public ECollisionChannel CollisionChannel;
}
