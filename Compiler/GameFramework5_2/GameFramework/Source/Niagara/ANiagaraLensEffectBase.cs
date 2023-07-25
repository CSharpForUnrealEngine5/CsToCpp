#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraLensEffectBase.h")]
///<summary>Niagara equivalent of AEmitterCameraLensEffectBase.</summary>
public partial class ANiagaraLensEffectBase : ANiagaraActor {
// NiagaraLensEffectBase
	public FTransform DesiredRelativeTransform;
	public float BaseAuthoredFOV;
	public bool bAllowMultipleInstances;
	public bool bResetWhenRetriggered;
	public TArray<UClass> EmittersToTreatAsSame;
	public APlayerCameraManager OwningCameraManager;
}
