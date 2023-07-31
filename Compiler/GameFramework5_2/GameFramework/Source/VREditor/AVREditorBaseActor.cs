#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an actor specifically for VR Editor that has roomspace transformation</summary>
[CppInclude("VREditorBaseActor.h")]
public partial class AVREditorBaseActor : AActor {
	///<summary>The VR mode that owns this actor</summary>
	public UVREditorMode VRMode;
}
