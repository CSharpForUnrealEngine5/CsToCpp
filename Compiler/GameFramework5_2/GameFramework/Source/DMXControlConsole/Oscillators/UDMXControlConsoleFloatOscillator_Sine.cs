#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates DMX Signals in a Sine Pattern</summary>
[CppInclude("Oscillators/DMXControlConsoleFloatOscillator_Sine.h")]
public partial class UDMXControlConsoleFloatOscillator_Sine : UDMXControlConsoleFloatOscillator {
	public static UClass StaticClass() {return default;}
	///<summary>The frequency of the sine wave, in Hz</summary>
	public float FrequencyHz;
	///<summary>The amplitude of the sine wave, in the range [0, 1]</summary>
	public float Amplitude;
	///<summary>The offset of the sine wave, in the range [0, 1]</summary>
	public float Offset;
}
