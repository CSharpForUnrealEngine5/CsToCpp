namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeImportHelper.h")]
public partial struct FLandscapeImportDescriptor {
	public TArray<FLandscapeImportResolution> ImportResolutions;
	public TArray<FLandscapeFileResolution> FileResolutions;
	public TArray<FLandscapeImportFileDescriptor> FileDescriptors;
	public FVector Scale;
}
