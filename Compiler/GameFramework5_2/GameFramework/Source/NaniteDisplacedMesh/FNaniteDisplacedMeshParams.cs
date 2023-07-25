#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteDisplacedMesh.h")]
public partial struct FNaniteDisplacedMeshParams {
// NaniteDisplacedMeshParams
	public UStaticMesh BaseMesh;
	public float RelativeError;
	public TArray<FNaniteDisplacedMeshDisplacementMap> DisplacementMaps;
}
