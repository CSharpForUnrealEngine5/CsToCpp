#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Set a temporal wave scalar value according to the sample distance from the field position.</summary>
public partial class UWaveScalar : UFieldNodeFloat {
// WaveScalar
	public  UWaveScalar SetWaveScalar(float Magnitude,FVector Position,float Wavelength,float Period,float Time,EWaveFunctionType Function,EFieldFalloffType Falloff) { return default; }
	public float Magnitude;
	public FVector Position;
	public float Wavelength;
	public float Period;
	public byte Function;
	public byte Falloff;
}
