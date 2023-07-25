#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/SnapshotTestActor.h")]
public partial class ASnapshotTestActor : ACharacter {
// SnapshotTestActor
	public int DeprecatedProperty_DEPRECATED;
	public int TransientProperty;
	public int IntProperty;
	public UObject ObjectReference;
	public TArray<UObject> ObjectArray;
	public TSet<UObject> ObjectSet;
	public TMap<string,UObject> ObjectMap;
	public FSoftObjectPath SoftPath;
	public TArray<FSoftObjectPath> SoftPathArray;
	public TSet<FSoftObjectPath> SoftPathSet;
	public TMap<string,FSoftObjectPath> SoftPathMap;
	public TSoftObjectPtr<UObject> SoftObjectPtr;
	public TArray<TSoftObjectPtr<UObject>> SoftObjectPtrArray;
	public TSet<TSoftObjectPtr<UObject>> SoftObjectPtrSet;
	public TMap<string,TSoftObjectPtr<UObject>> SoftObjectPtrMap;
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	public TArray<TWeakObjectPtr<UObject>> WeakObjectPtrArray;
	public TSet<TWeakObjectPtr<UObject>> WeakObjectPtrSet;
	public TMap<string,TWeakObjectPtr<UObject>> WeakObjectPtrMap;
	public UActorComponent ExternalComponentReference;
	public UObject ExternalComponentReferenceAsUObject;
	public UMaterialInterface GradientLinearMaterial;
	public UMaterialInterface GradientRadialMaterial;
	public UStaticMesh CubeMesh;
	public UStaticMesh CylinderMesh;
	public UStaticMeshComponent StaticMeshComponent;
	public UInstancedStaticMeshComponent InstancedMeshComponent;
	public UPointLightComponent PointLightComponent;
	public USnapshotTestComponent TestComponent;
	public USubobject EditableInstancedSubobject_DefaultSubobject;
	public USubobject InstancedOnlySubobject_DefaultSubobject;
	public USubobject NakedSubobject_DefaultSubobject;
	public USubobject EditOnlySubobject_OptionalSubobject;
	public TArray<USubobject> EditableInstancedSubobjectArray_OptionalSubobject;
	public TMap<string,USubobject> EditableInstancedSubobjectMap_OptionalSubobject;
	public TArray<USubobject> EditOnlySubobjectArray_OptionalSubobject;
	public TMap<string,USubobject> EditOnlySubobjectMap_OptionalSubobject;
}
