namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a temporal wave scalar value according to the sample distance from the field position.</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UWaveScalar : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Set a temporal wave scalar value according to the sample distance from the field position.</summary>
	public UWaveScalar SetWaveScalar(float Magnitude,FVector Position,float Wavelength,float Period,float Time,EWaveFunctionType Function,EFieldFalloffType Falloff) { return default; }
	///<summary>Magnitude of the wave function</summary>
	public float Magnitude;
	///<summary>Center position of the wave field</summary>
	public FVector Position;
	///<summary>Distance between 2 wave peaks</summary>
	public float Wavelength;
	///<summary>Time over which the wave will travel from one peak to another one. The wave velocity is proportional to wavelength/period</summary>
	public float Period;
	///<summary>Wave function used for the field</summary>
	public EWaveFunctionType Function;
	///<summary>Type of falloff function used if the falloff function is picked</summary>
	public EFieldFalloffType Falloff;
}
