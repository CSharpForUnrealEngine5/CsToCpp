namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StereoStaticMeshComponent.h")]
public partial class UStereoStaticMeshComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>EyeToRender</summary>
	public ESPStereoCameraLayer EyeToRender;
}
