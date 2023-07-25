#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGridManager.h")]
///<summary>This struct keeps track of the values of the properties before new values were applied, so we can rollback to the previous state.</summary>
public partial struct FRenderGridManagerPreviousPropValues {
// RenderGridManagerPreviousPropValues
	public TMap<URenderGridPropRemoteControl,FRenderGridRemoteControlPropertyData> RemoteControlData;
}
