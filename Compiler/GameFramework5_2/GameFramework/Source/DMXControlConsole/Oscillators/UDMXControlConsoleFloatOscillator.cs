#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A value Oscillator that can be used in the DMX Control Console. Outputs float (normalized values)</summary>
[CppInclude("Oscillators/DMXControlConsoleFloatOscillator.h")]
public partial class UDMXControlConsoleFloatOscillator : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets a normalized value that is sent as DMX</summary>
	public  float GetNormalizedValue(float DeltaTime) { return default; }
}
