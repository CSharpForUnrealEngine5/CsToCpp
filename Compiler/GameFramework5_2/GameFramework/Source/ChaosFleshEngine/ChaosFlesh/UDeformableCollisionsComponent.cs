namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformableCollisionsComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformableCollisionsComponent.h")]
public partial class UDeformableCollisionsComponent : UDeformablePhysicsComponent {
	public static UClass StaticClass() {return default;}
	///<summary>AddStaticMeshComponent</summary>
	public void AddStaticMeshComponent(UStaticMeshComponent StaticMeshComponent) {}
	///<summary>RemoveStaticMeshComponent</summary>
	public void RemoveStaticMeshComponent(UStaticMeshComponent StaticMeshComponent) {}
	///<summary>CollisionBodies</summary>
	public TArray<UStaticMeshComponent> CollisionBodies;
}
