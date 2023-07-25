#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VCamUIFunctionLibrary.h")]
///<summary>* Function Library primarily used for exposing functionality of UI related structs to Blueprints</summary>
public partial class UVCamUIFunctionLibrary : UBlueprintFunctionLibrary {
// VCamUIFunctionLibrary
	public bool IsConnected_VCamConnection(FVCamConnection Connection) { return default; }
	public string GetConnectionPointName_VCamConnection(FVCamConnection Connection) { return default; }
	public UObject GetConnectedModifier_VCamConnection(FVCamConnection Connection) { return default; }
	public UObject GetConnectedInputAction_VCamConnection(FVCamConnection Connection) { return default; }
	public bool GetConnectionByName_VCamWidget(UObject Widget,string ConnectionId,FVCamConnection OutConnection) { return default; }
	public bool IsConnected_VCamWidget(UObject Widget,string ConnectionId,bool bOutIsConnected) { return default; }
	public bool GetConnectionPointName_VCamWidget(UObject Widget,string ConnectionId,string OutConnectionPointName) { return default; }
	public bool GetConnectedModifier_VCamWidget(UObject Widget,string ConnectionId,UObject OutModifier) { return default; }
	public bool GetConnectedInputAction_VCamWidget(UObject Widget,string ConnectionId,UObject OutInputAction) { return default; }
}
