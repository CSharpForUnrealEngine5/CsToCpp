#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResonanceAudioReverb.h")]
public partial struct FResonanceAudioReverbPluginSettings {
	public bool bEnableRoomEffects;
	public bool bGetTransformFromAudioVolume;
	public FVector RoomPosition;
	public FQuat RoomRotation;
	public FVector RoomDimensions;
	public ERaMaterialName LeftWallMaterial;
	public ERaMaterialName RightWallMaterial;
	public ERaMaterialName FloorMaterial;
	public ERaMaterialName CeilingMaterial;
	public ERaMaterialName FrontWallMaterial;
	public ERaMaterialName BackWallMaterial;
	public float ReflectionScalar;
	public float ReverbGain;
	public float ReverbTimeModifier;
	public float ReverbBrightness;
}
