namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for a Fader in the DMX Control Console.</summary>
[CppInclude("DMXControlConsoleFaderBase.h")]
public partial class UDMXControlConsoleFaderBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Cached Name of the Fader</summary>
	public string FaderName;
	///<summary>The number of channels this Fader uses</summary>
	public EDMXFixtureSignalFormat DataType;
	///<summary>The universe the should send to fader</summary>
	public int UniverseID;
	///<summary>The starting channel Address to send DMX to</summary>
	public int StartingAddress;
	///<summary>The end channel Address to send DMX to</summary>
	public int EndingAddress;
	///<summary>The current Fader Value</summary>
	public uint Value;
	///<summary>Fader&#39;s default Value</summary>
	public uint DefaultValue;
	///<summary>The minimum Fader Value</summary>
	public uint MinValue;
	///<summary>The maximum Fader Value</summary>
	public uint MaxValue;
	///<summary>Use Least Significant Byte mode. Individual bytes(channels) be interpreted with the first bytes being the lowest part of the number(endianness).</summary>
	public bool bUseLSBMode;
	///<summary>Oscillator that is used for this fader</summary>
	public TSoftObjectPtr<UClass> FloatOscillatorClass;
	///<summary>Float Oscillator applied to this channel</summary>
	public UDMXControlConsoleFloatOscillator FloatOscillator;
	///<summary>If true, the fader doesn&#39;t send DMX</summary>
	public bool bIsMuted;
	///<summary>If true, Fader&#39;s value can&#39;t be changed</summary>
	public bool bIsLocked;
	///<summary>If true, the property is editable in editor</summary>
	public bool bCanEditDMXAssignment;
}
