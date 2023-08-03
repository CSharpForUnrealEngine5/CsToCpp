#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
