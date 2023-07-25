#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileExchange {
// LensFileExchange
	public FLensFileMetadata Metadata;
	public FLensFileSensorDimensions SensorDimensions;
	public FLensFileImageDimensions ImageDimensions;
	public TArray<FLensFileParameterTable> CameraParameterTables;
	public TArray<FLensFileParameterTable> EncoderTables;
}
