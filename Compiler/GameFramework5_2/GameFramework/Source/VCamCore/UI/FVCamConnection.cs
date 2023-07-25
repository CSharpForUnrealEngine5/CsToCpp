#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VCamConnectionStructs.h")]
///<summary>* A VCam Connection allows an external object (primarily widgets) to communicate with VCam Modifiers through Connection Points that have known properties.</summary>
public partial struct FVCamConnection {
// VCamConnection
	public TArray<UClass> RequiredInterfaces;
	public TArray<UClass> OptionalInterfaces;
	public bool bRequiresInputAction;
	public EInputActionValueType ActionType;
	public bool bManuallyConfigureConnection;
	public FVCamConnectionTargetSettings ConnectionTargetSettings;
	public UInputAction ConnectedAction;
	public UVCamModifier ConnectedModifier;
}
