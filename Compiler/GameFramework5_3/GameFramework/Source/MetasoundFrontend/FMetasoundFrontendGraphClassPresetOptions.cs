namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Preset options related to a parent graph class.  A graph class with bIsPreset set to true</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendGraphClassPresetOptions {
	public bool bIsPreset;
	public TSet<FName> InputsInheritingDefault;
}
