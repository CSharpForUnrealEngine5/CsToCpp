namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeTeleporter.h")]
public partial class AXRCreativeTeleporter : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>LeftController</summary>
	public UMotionControllerComponent LeftController;
	///<summary>RightController</summary>
	public UMotionControllerComponent RightController;
	///<summary>TeleportMesh</summary>
	public UStaticMeshComponent TeleportMesh;
}
