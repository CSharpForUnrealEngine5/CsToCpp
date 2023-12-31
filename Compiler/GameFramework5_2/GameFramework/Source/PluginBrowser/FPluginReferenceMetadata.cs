namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We use this object to display plugin reference properties using details view.</summary>
[CppInclude("PluginMetadataObject.h")]
public partial struct FPluginReferenceMetadata {
	public string Name;
	public bool bOptional;
	public bool bEnabled;
}
