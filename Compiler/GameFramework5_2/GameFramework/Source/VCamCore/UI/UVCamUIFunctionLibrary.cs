#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VCamUIFunctionLibrary.h")]
///<summary>* Function Library primarily used for exposing functionality of UI related structs to Blueprints</summary>
public partial class UVCamUIFunctionLibrary : UBlueprintFunctionLibrary {
// VCamUIFunctionLibrary
	public static bool IsConnected_VCamConnection(FVCamConnection Connection) { return default; }
	public static string GetConnectionPointName_VCamConnection(FVCamConnection Connection) { return default; }
	public static UVCamModifier GetConnectedModifier_VCamConnection(FVCamConnection Connection) { return default; }
	public static UInputAction GetConnectedInputAction_VCamConnection(FVCamConnection Connection) { return default; }
	public static bool GetConnectionByName_VCamWidget(UVCamWidget Widget,string ConnectionId,FVCamConnection OutConnection) { return default; }
	public static bool IsConnected_VCamWidget(UVCamWidget Widget,string ConnectionId,bool bOutIsConnected) { return default; }
	public static bool GetConnectionPointName_VCamWidget(UVCamWidget Widget,string ConnectionId,string OutConnectionPointName) { return default; }
	public static bool GetConnectedModifier_VCamWidget(UVCamWidget Widget,string ConnectionId,UVCamModifier OutModifier) { return default; }
	public static bool GetConnectedInputAction_VCamWidget(UVCamWidget Widget,string ConnectionId,UInputAction OutInputAction) { return default; }
}
