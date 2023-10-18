namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct for setting string console ini values.</summary>
[CppInclude("Editor/AssetGuideline.h")]
public partial struct FIniStringValue {
	public string Section;
	public string Key;
	public string Value;
	public string Filename;
}
