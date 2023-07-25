using CSharpToCpp.Utilities;

namespace GameFramework;

[CppInclude("NiagaraFunctionLibrary.h")]
public class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary {
    public static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject, UNiagaraSystem SystemTemplate,
        FVector Location, FRotator Rotation = default, FVector Scale = default, bool bAutoDestroy = true, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = 0, bool bPreCullCheck = true){ return null; }
}

