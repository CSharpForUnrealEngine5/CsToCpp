namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct keeps track of the values of the properties before new values were applied, so we can rollback to the previous state.</summary>
[CppInclude("RenderGrid/RenderGridManager.h")]
public partial struct FRenderGridManagerPreviousPropValues {
	public TMap<URenderGridPropRemoteControl,FRenderGridRemoteControlPropertyData> RemoteControlData;
}
