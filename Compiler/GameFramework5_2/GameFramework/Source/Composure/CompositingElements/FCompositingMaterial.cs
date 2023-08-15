namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
public partial struct FCompositingMaterial {
	public UMaterialInterface Material;
	public TMap<FName,FName> ParamPassMappings;
	public TMap<FName,FNamedCompMaterialParam> RequiredMaterialParams;
	public TArray<FName> EditorHiddenParams;
	public TMap<FName,FLinearColor> VectorOverrideProxies;
	public UMaterialInstanceDynamic CachedMID;
}
