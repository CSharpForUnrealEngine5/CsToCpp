#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/EmitterCameraLensEffectBase.h")]
public partial class AEmitterCameraLensEffectBase : AEmitter {
// EmitterCameraLensEffectBase
	public UParticleSystem PS_CameraEffect;
	public APlayerCameraManager BaseCamera;
	public FTransform RelativeTransform;
	public float BaseFOV;
	public bool bAllowMultipleInstances;
	public bool bResetWhenRetriggered;
	public TArray<UClass> EmittersToTreatAsSame;
	public float DistFromCamera_DEPRECATED;
}
