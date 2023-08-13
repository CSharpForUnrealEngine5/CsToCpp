namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewTargetPolicy/GameplayViewTargetPolicy.h")]
public partial struct FDeterminePlayerControllersTargetPolicyParams {
	public UVCamOutputProviderBase OutputProvider;
	public UCineCameraComponent CameraToAffect;
	public bool bNewIsActive;
}
