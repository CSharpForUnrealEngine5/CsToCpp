namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing information about one hit of a trace, such as point of impact and surface normal at that point.</summary>
[CppInclude("Engine/HitResult.h")]
public partial struct FHitResult {
	public int FaceIndex;
	public float Time;
	public float Distance;
	public FVector_NetQuantize Location;
	public FVector_NetQuantize ImpactPoint;
	public FVector_NetQuantizeNormal Normal;
	public FVector_NetQuantizeNormal ImpactNormal;
	public FVector_NetQuantize TraceStart;
	public FVector_NetQuantize TraceEnd;
	public float PenetrationDepth;
	public int MyItem;
	public int Item;
	public byte ElementIndex;
	public bool bBlockingHit;
	public bool bStartPenetrating;
	public TWeakObjectPtr<UPhysicalMaterial> PhysMaterial;
	public FActorInstanceHandle HitObjectHandle;
	public TWeakObjectPtr<UPrimitiveComponent> Component;
	public FName BoneName;
	public FName MyBoneName;
}
