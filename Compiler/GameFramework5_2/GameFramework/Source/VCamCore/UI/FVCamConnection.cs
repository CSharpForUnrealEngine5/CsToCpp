#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* A VCam Connection allows an external object (primarily widgets) to communicate with VCam Modifiers through Connection Points that have known properties.</summary>
[CppInclude("UI/VCamConnectionStructs.h")]
public partial struct FVCamConnection {
	public TArray<UClass> RequiredInterfaces;
	public TArray<UClass> OptionalInterfaces;
	public bool bRequiresInputAction;
	public EInputActionValueType ActionType;
	public bool bManuallyConfigureConnection;
	public FVCamConnectionTargetSettings ConnectionTargetSettings;
	public UInputAction ConnectedAction;
	public UVCamModifier ConnectedModifier;
}
