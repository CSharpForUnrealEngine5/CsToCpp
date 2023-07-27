#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenColorIOConfiguration.h")]
///<summary>Asset to manage allowed OpenColorIO color spaces. This will create required transform objects.</summary>
public partial class UOpenColorIOConfiguration : UObject {
// OpenColorIOConfiguration
	public  void ReloadExistingColorspaces() {}
	public FFilePath ConfigurationFile;
	public TArray<FOpenColorIOColorSpace> DesiredColorSpaces;
	public TArray<FOpenColorIODisplayView> DesiredDisplayViews;
	public TArray<UOpenColorIOColorTransform> ColorTransforms;
}
