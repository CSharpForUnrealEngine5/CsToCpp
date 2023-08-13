namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client that created a renderer.</summary>
[CppInclude("StageAppResponse.h")]
public partial struct FRCPreviewRendererCreatedEvent {
	public string Type;
	public int RendererId;
}
