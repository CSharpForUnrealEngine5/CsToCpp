namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Automatically scales the user when dragging the world and pressing the touchpad</summary>
[CppInclude("Teleporter/VREditorAutoScaler.h")]
public partial class UVREditorAutoScaler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Owning mode</summary>
	public UVREditorMode VRMode;
}
