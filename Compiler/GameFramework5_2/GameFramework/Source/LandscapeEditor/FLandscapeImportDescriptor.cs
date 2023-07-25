#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeImportHelper.h")]
public partial struct FLandscapeImportDescriptor {
// LandscapeImportDescriptor
	public TArray<FLandscapeImportResolution> ImportResolutions;
	public TArray<FLandscapeFileResolution> FileResolutions;
	public TArray<FLandscapeImportFileDescriptor> FileDescriptors;
	public FVector Scale;
}
