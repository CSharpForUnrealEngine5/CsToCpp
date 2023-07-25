#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplineMeshesActor.h")]
///<summary>This class is only intended to be used by UWorldPartitionLandscapeSplineMeshesBuilder which extracts and clones</summary>
public partial class ALandscapeSplineMeshesActor : APartitionActor {
// LandscapeSplineMeshesActor
	public TArray<UStaticMeshComponent> StaticMeshComponents;
	public FGuid GridGuid;
}
