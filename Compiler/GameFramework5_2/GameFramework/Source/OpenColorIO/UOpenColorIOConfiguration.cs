namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset to manage allowed OpenColorIO color spaces. This will create required transform objects.</summary>
[CppInclude("OpenColorIOConfiguration.h")]
public partial class UOpenColorIOConfiguration : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>This forces to reload colorspaces and corresponding shaders if those are not loaded already.</summary>
	public void ReloadExistingColorspaces() {}
	///<summary>ConfigurationFile</summary>
	public FFilePath ConfigurationFile;
	///<summary>DesiredColorSpaces</summary>
	public TArray<FOpenColorIOColorSpace> DesiredColorSpaces;
	///<summary>DesiredDisplayViews</summary>
	public TArray<FOpenColorIODisplayView> DesiredDisplayViews;
	///<summary>ColorTransforms</summary>
	public TArray<UOpenColorIOColorTransform> ColorTransforms;
}
