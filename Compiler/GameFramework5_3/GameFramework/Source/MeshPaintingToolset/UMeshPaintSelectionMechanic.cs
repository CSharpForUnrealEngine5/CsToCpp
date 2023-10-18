namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshPaintInteractions.h")]
public partial class UMeshPaintSelectionMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>CachedClickedComponents</summary>
	public TArray<UMeshComponent> CachedClickedComponents;
	///<summary>CachedClickedActors</summary>
	public TArray<AActor> CachedClickedActors;
}
