#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMeshRendererProperties.h")]
public partial struct FNiagaraMeshRendererMeshProperties {
	public UStaticMesh Mesh;
	public FNiagaraUserParameterBinding UserParamBinding_DEPRECATED;
	public FNiagaraParameterBinding MeshParameterBinding;
	public FVector Scale;
	public FRotator Rotation;
	public FVector PivotOffset;
	public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace;
}
