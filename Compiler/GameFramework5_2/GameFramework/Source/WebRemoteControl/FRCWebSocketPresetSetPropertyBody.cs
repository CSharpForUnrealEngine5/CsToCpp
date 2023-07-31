#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to modify a property exposed in a preset.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketPresetSetPropertyBody {
	public string PresetName;
	public string PropertyLabel;
	public ERCModifyOperation Operation;
	public ERCTransactionMode TransactionMode;
	public int TransactionId;
	public bool ResetToDefault;
	public long SequenceNumber;
}
