#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeImportHelper.h")]
public partial struct FLandscapeImportDescriptor {
	public TArray<FLandscapeImportResolution> ImportResolutions;
	public TArray<FLandscapeFileResolution> FileResolutions;
	public TArray<FLandscapeImportFileDescriptor> FileDescriptors;
	public FVector Scale;
}
