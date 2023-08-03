#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/EmitterCameraLensEffectBase.h")]
public partial class AEmitterCameraLensEffectBase : AEmitter {
	public static UClass StaticClass() {return default;}
	///<summary>Particle System to use</summary>
	public UParticleSystem PS_CameraEffect;
	///<summary>Camera this emitter is attached to, will be notified when emitter is destroyed</summary>
	public APlayerCameraManager BaseCamera;
	///<summary>Effect-to-camera transform to allow arbitrary placement of the particle system .</summary>
	public FTransform RelativeTransform;
	///<summary>This is the assumed FOV for which the effect was authored. The code will make automatic adjustments to make it look the same at different FOVs</summary>
	public float BaseFOV;
	///<summary>true if multiple instances of this emitter can exist simultaneously, false otherwise.</summary>
	public bool bAllowMultipleInstances;
	///<summary>If bAllowMultipleInstances is true and this effect is retriggered, the particle system will be reset if this is true</summary>
	public bool bResetWhenRetriggered;
	///<summary>If an emitter class in this array is currently playing, do not play this effect.</summary>
	public TArray<UClass> EmittersToTreatAsSame;
	///<summary>UE_DEPRECATED(4.11)</summary>
	public float DistFromCamera_DEPRECATED;
}
