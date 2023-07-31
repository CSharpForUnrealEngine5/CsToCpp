#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset to manage allowed OpenColorIO color spaces. This will create required transform objects.</summary>
[CppInclude("OpenColorIOConfiguration.h")]
public partial class UOpenColorIOConfiguration : UObject {
	///<summary>This forces to reload colorspaces and corresponding shaders if those are not loaded already.</summary>
	public  void ReloadExistingColorspaces() {}
	///<summary>ConfigurationFile</summary>
	public FFilePath ConfigurationFile;
	///<summary>DesiredColorSpaces</summary>
	public TArray<FOpenColorIOColorSpace> DesiredColorSpaces;
	///<summary>DesiredDisplayViews</summary>
	public TArray<FOpenColorIODisplayView> DesiredDisplayViews;
	///<summary>ColorTransforms</summary>
	public TArray<UOpenColorIOColorTransform> ColorTransforms;
}
