#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates DMX Signals in a Square Wave Pattern</summary>
[CppInclude("Oscillators/DMXControlConsoleFloatOscillator_Square.h")]
public partial class UDMXControlConsoleFloatOscillator_Square : UDMXControlConsoleFloatOscillator {
	///<summary>The frequency of the square wave, in Hz</summary>
	public float FrequencyHz;
	///<summary>The amplitude of the square wave, in the range [0, 1]</summary>
	public float Amplitude;
	///<summary>The offset of the square wave, in the range [0, 1]</summary>
	public float Offset;
}
