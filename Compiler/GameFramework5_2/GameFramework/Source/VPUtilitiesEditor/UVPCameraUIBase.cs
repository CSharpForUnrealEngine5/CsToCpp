namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPCameraUIBase.h")]
public partial class UVPCameraUIBase : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedCamera</summary>
	public ACameraActor SelectedCamera;
	///<summary>SelectedCameraComponent</summary>
	public UCameraComponent SelectedCameraComponent;
	///<summary>OnSelectedCameraChanged</summary>
	public void OnSelectedCameraChanged() {}
}
