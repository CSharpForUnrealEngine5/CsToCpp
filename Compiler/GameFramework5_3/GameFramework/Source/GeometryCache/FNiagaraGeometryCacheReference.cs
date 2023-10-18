namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGeometryCacheRendererProperties.h")]
public partial struct FNiagaraGeometryCacheReference {
	public UGeometryCache GeometryCache;
	public FNiagaraUserParameterBinding GeometryCacheUserParamBinding;
	public TArray<UMaterialInterface> OverrideMaterials;
	public TArray<FNiagaraGeometryCacheMICOverride> MICOverrideMaterials;
}
