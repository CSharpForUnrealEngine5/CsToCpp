#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Niagara equivalent of AEmitterCameraLensEffectBase.</summary>
[CppInclude("NiagaraLensEffectBase.h")]
public partial class ANiagaraLensEffectBase : ANiagaraActor {
	///<summary>Relative offset from the camera (where X is out from the camera)</summary>
	public FTransform DesiredRelativeTransform;
	///<summary>FOVs that differ from this may cause adjustments in positioning.</summary>
	public float BaseAuthoredFOV;
	///<summary>Are multiple instances of the effect allowed?</summary>
	public bool bAllowMultipleInstances;
	///<summary>When an instance of this effect is retriggered (because more than one instance is not allowed)</summary>
	public bool bResetWhenRetriggered;
	///<summary>If an effect class in this array is currently playing, do not play this effect.</summary>
	public TArray<UClass> EmittersToTreatAsSame;
	///<summary>OwningCameraManager</summary>
	public APlayerCameraManager OwningCameraManager;
}
