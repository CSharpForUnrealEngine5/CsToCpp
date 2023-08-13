namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteDisplacedMesh.h")]
public partial struct FNaniteDisplacedMeshParams {
	public UStaticMesh BaseMesh;
	public float RelativeError;
	public TArray<FNaniteDisplacedMeshDisplacementMap> DisplacementMaps;
}
