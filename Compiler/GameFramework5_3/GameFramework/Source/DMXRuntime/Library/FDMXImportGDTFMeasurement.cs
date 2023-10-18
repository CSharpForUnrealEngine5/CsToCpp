namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFMeasurement {
	public float Physical;
	public float LuminousIntensity;
	public float Transmission;
	public EDMXImportGDTFInterpolationTo InterpolationTo;
	public TArray<FDMXImportGDTFMeasurementPoint> MeasurementPoints;
}
