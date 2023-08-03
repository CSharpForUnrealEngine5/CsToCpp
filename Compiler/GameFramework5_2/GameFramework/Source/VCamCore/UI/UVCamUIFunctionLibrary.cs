#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Function Library primarily used for exposing functionality of UI related structs to Blueprints</summary>
[CppInclude("UI/VCamUIFunctionLibrary.h")]
public partial class UVCamUIFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>* Checks whether a given VCam Connection is successfully connected.</summary>
	public static bool IsConnected_VCamConnection(FVCamConnection Connection) { return default; }
	///<summary>* Gets the name of the associated Connection Point for a given VCam Connection.</summary>
	public static string GetConnectionPointName_VCamConnection(FVCamConnection Connection) { return default; }
	///<summary>* Gets the Connected Modifier for the given VCam Connection</summary>
	public static UVCamModifier GetConnectedModifier_VCamConnection(FVCamConnection Connection) { return default; }
	///<summary>* Gets the Connected Input Action for the given VCam Connection</summary>
	public static UInputAction GetConnectedInputAction_VCamConnection(FVCamConnection Connection) { return default; }
	///<summary>Gets a connection by its ID.</summary>
	public static bool GetConnectionByName_VCamWidget(UVCamWidget Widget,string ConnectionId,FVCamConnection OutConnection) { return default; }
	///<summary>Gets whether the ConnectionId is connected on the widget.</summary>
	public static bool IsConnected_VCamWidget(UVCamWidget Widget,string ConnectionId,bool bOutIsConnected) { return default; }
	///<summary>Gets the connection point the connection ConnectionId attempts to connect to on the widget.</summary>
	public static bool GetConnectionPointName_VCamWidget(UVCamWidget Widget,string ConnectionId,string OutConnectionPointName) { return default; }
	///<summary>Gets the modifier connected to ConnectionId on the widget.</summary>
	public static bool GetConnectedModifier_VCamWidget(UVCamWidget Widget,string ConnectionId,UVCamModifier OutModifier) { return default; }
	///<summary>Gets the input action mapped to ConnectionId on the widget.</summary>
	public static bool GetConnectedInputAction_VCamWidget(UVCamWidget Widget,string ConnectionId,UInputAction OutInputAction) { return default; }
}
