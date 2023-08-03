#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
