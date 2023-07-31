#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteDisplacedMesh.h")]
public partial struct FNaniteDisplacedMeshParams {
	public UStaticMesh BaseMesh;
	public float RelativeError;
	public TArray<FNaniteDisplacedMeshDisplacementMap> DisplacementMaps;
}
