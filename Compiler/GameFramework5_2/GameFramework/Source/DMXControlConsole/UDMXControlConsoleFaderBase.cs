#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleFaderBase.h")]
///<summary>Base class for a Fader in the DMX Control Console.</summary>
public partial class UDMXControlConsoleFaderBase : UObject {
// DMXControlConsoleFaderBase
	public string FaderName;
	public int EndingAddress;
	public uint Value;
	public uint MinValue;
	public uint MaxValue;
	public TSoftObjectPtr<UClass> FloatOscillatorClass;
	public UDMXControlConsoleFloatOscillator FloatOscillator;
	public bool bIsMuted;
}
