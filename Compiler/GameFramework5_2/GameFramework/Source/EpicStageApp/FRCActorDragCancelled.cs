#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client when a drag operation is cancelled by the engine.</summary>
[CppInclude("StageAppResponse.h")]
public partial struct FRCActorDragCancelled {
	public string Type;
	public int RendererId;
}
