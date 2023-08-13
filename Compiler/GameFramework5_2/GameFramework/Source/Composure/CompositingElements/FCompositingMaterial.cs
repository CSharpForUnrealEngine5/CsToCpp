namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
public partial struct FCompositingMaterial {
	public UMaterialInterface Material;
	public TMap<string,string> ParamPassMappings;
	public TMap<string,FNamedCompMaterialParam> RequiredMaterialParams;
	public TArray<string> EditorHiddenParams;
	public TMap<string,FLinearColor> VectorOverrideProxies;
	public UMaterialInstanceDynamic CachedMID;
}
