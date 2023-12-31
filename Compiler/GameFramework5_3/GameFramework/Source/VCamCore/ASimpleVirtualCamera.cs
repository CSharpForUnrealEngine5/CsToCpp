namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple native virtual camera actor</summary>
[CppInclude("SimpleVirtualCamera.h")]
public partial class ASimpleVirtualCamera : ACineCameraActor {
	public static UClass StaticClass() {return default;}
	///<summary>VCamComponent</summary>
	public UVCamComponent VCamComponent;
}
