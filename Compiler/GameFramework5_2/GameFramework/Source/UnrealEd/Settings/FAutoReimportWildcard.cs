namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A filter used by the auto reimport manager to explicitly include/exclude files matching the specified wildcard</summary>
[CppInclude("Settings/EditorLoadingSavingSettings.h")]
public partial struct FAutoReimportWildcard {
	public string Wildcard;
	public bool bInclude;
}
