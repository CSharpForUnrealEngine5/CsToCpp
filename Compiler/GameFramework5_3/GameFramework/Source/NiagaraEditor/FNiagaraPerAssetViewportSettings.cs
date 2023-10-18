namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>View settings that are saved per asset and aren&#39;t shared between different Niagara viewports.</summary>
[CppInclude("NiagaraSystemEditorData.h")]
public partial struct FNiagaraPerAssetViewportSettings {
	public FVector ViewLocation;
	public FRotator ViewRotation;
	public bool bUseOrbitMode;
}
