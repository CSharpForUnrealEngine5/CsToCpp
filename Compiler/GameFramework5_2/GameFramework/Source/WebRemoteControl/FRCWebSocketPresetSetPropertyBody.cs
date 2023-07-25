#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to modify a property exposed in a preset.</summary>
public partial struct FRCWebSocketPresetSetPropertyBody {
// RCWebSocketPresetSetPropertyBody
	public string PresetName;
	public string PropertyLabel;
	public ERCModifyOperation Operation;
	public ERCTransactionMode TransactionMode;
	public int TransactionId;
	public bool ResetToDefault;
	public long SequenceNumber;
}
