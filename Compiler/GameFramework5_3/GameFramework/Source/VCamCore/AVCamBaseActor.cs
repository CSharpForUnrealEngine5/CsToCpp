namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility base class which sets up a UVCamComponent with a Cine Camera.</summary>
[CppInclude("VCamBaseActor.h")]
public partial class AVCamBaseActor : ACineCameraActor {
	public static UClass StaticClass() {return default;}
	///<summary>GetVCamComponent</summary>
	public UVCamComponent GetVCamComponent() { return default; }
	///<summary>VCamComponent</summary>
	public UVCamComponent VCamComponent;
}
