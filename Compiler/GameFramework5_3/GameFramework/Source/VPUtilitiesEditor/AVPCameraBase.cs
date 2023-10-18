namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPCameraBase.h")]
public partial class AVPCameraBase : ACineCameraActor {
	public static UClass StaticClass() {return default;}
	///<summary>Remove the preview and clear the list of selected user. Another user may have the camera selected and will re-add it later.</summary>
	public void ResetPreview() {}
	///<summary>Contains the name of users in an MU session that have selected this</summary>
	public TArray<FGuid> SelectedByUsers;
}
