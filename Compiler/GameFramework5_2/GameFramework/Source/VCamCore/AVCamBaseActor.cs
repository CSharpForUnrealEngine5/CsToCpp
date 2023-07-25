#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamBaseActor.h")]
///<summary>Utility base class which sets up a UVCamComponent with a Cine Camera.</summary>
public partial class AVCamBaseActor : ACineCameraActor {
// VCamBaseActor
	public UObject GetVCamComponent() { return default; }
	public UVCamComponent VCamComponent;
}
