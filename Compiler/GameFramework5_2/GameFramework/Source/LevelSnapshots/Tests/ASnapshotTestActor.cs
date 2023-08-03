#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/SnapshotTestActor.h")]
public partial class ASnapshotTestActor : ACharacter {
	public static UClass StaticClass() {return default;}
	///<summary>***************** Skipped properties  *******************</summary>
	public int DeprecatedProperty_DEPRECATED;
	///<summary>TransientProperty</summary>
	public int TransientProperty;
	///<summary>IntProperty</summary>
	public int IntProperty;
	///<summary>***************** Raw references  *******************</summary>
	public UObject ObjectReference;
	///<summary>ObjectArray</summary>
	public TArray<UObject> ObjectArray;
	///<summary>ObjectSet</summary>
	public TSet<UObject> ObjectSet;
	///<summary>ObjectMap</summary>
	public TMap<string,UObject> ObjectMap;
	///<summary>***************** FSoftObjectPath  *******************</summary>
	public FSoftObjectPath SoftPath;
	///<summary>SoftPathArray</summary>
	public TArray<FSoftObjectPath> SoftPathArray;
	///<summary>SoftPathSet</summary>
	public TSet<FSoftObjectPath> SoftPathSet;
	///<summary>SoftPathMap</summary>
	public TMap<string,FSoftObjectPath> SoftPathMap;
	///<summary>***************** TSoftObjectPtr  *******************</summary>
	public TSoftObjectPtr<UObject> SoftObjectPtr;
	///<summary>SoftObjectPtrArray</summary>
	public TArray<TSoftObjectPtr<UObject>> SoftObjectPtrArray;
	///<summary>SoftObjectPtrSet</summary>
	public TSet<TSoftObjectPtr<UObject>> SoftObjectPtrSet;
	///<summary>SoftObjectPtrMap</summary>
	public TMap<string,TSoftObjectPtr<UObject>> SoftObjectPtrMap;
	///<summary>***************** TWeakObjectPtr  *******************</summary>
	public TWeakObjectPtr<UObject> WeakObjectPtr;
	///<summary>WeakObjectPtrArray</summary>
	public TArray<TWeakObjectPtr<UObject>> WeakObjectPtrArray;
	///<summary>WeakObjectPtrSet</summary>
	public TSet<TWeakObjectPtr<UObject>> WeakObjectPtrSet;
	///<summary>WeakObjectPtrMap</summary>
	public TMap<string,TWeakObjectPtr<UObject>> WeakObjectPtrMap;
	///<summary>***************** External component references  *******************</summary>
	public UActorComponent ExternalComponentReference;
	///<summary>ExternalComponentReferenceAsUObject</summary>
	public UObject ExternalComponentReferenceAsUObject;
	///<summary>***************** External references  *******************</summary>
	public UMaterialInterface GradientLinearMaterial;
	///<summary>GradientRadialMaterial</summary>
	public UMaterialInterface GradientRadialMaterial;
	///<summary>CubeMesh</summary>
	public UStaticMesh CubeMesh;
	///<summary>CylinderMesh</summary>
	public UStaticMesh CylinderMesh;
	///<summary>***************** Subobject Component references  *******************</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>InstancedMeshComponent</summary>
	public UInstancedStaticMeshComponent InstancedMeshComponent;
	///<summary>PointLightComponent</summary>
	public UPointLightComponent PointLightComponent;
	///<summary>TestComponent</summary>
	public USnapshotTestComponent TestComponent;
	///<summary>***************** Subobject references  *******************</summary>
	public USubobject EditableInstancedSubobject_DefaultSubobject;
	///<summary>InstancedOnlySubobject_DefaultSubobject</summary>
	public USubobject InstancedOnlySubobject_DefaultSubobject;
	///<summary>NakedSubobject_DefaultSubobject</summary>
	public USubobject NakedSubobject_DefaultSubobject;
	///<summary>EditOnlySubobject_OptionalSubobject</summary>
	public USubobject EditOnlySubobject_OptionalSubobject;
	///<summary>EditableInstancedSubobjectArray_OptionalSubobject</summary>
	public TArray<USubobject> EditableInstancedSubobjectArray_OptionalSubobject;
	///<summary>EditableInstancedSubobjectMap_OptionalSubobject</summary>
	public TMap<string,USubobject> EditableInstancedSubobjectMap_OptionalSubobject;
	///<summary>EditOnlySubobjectArray_OptionalSubobject</summary>
	public TArray<USubobject> EditOnlySubobjectArray_OptionalSubobject;
	///<summary>EditOnlySubobjectMap_OptionalSubobject</summary>
	public TMap<string,USubobject> EditOnlySubobjectMap_OptionalSubobject;
}
