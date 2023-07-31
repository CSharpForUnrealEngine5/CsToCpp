#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a Fader in the DMX Control Console.</summary>
[CppInclude("DMXControlConsoleFaderBase.h")]
public partial class UDMXControlConsoleFaderBase : UObject {
	///<summary>Cached Name of the Fader</summary>
	public string FaderName;
	///<summary>The end channel Address to send DMX to</summary>
	public int EndingAddress;
	///<summary>The current Fader Value</summary>
	public uint Value;
	///<summary>The minimum Fader Value</summary>
	public uint MinValue;
	///<summary>The maximum Fader Value</summary>
	public uint MaxValue;
	///<summary>Oscillator that is used for this fader</summary>
	public TSoftObjectPtr<UClass> FloatOscillatorClass;
	///<summary>Float Oscillator applied to this channel</summary>
	public UDMXControlConsoleFloatOscillator FloatOscillator;
	///<summary>If true, the fader doesn&#39;t send DMX</summary>
	public bool bIsMuted;
}
