namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an actor specifically for VR Editor that has roomspace transformation</summary>
[CppInclude("VREditorBaseActor.h")]
public partial class AVREditorBaseActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>The VR mode that owns this actor</summary>
	public UVREditorMode VRMode;
}
