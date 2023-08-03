#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleVariablesEditorProjectSettings.h")]
public partial class UConsoleVariablesEditorProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When a row is unchecked, its associated variable&#39;s value will be set to the value recorded when the plugin was loaded.</summary>
	public EConsoleVariablesEditorRowDisplayType UncheckedRowDisplayType;
	///<summary>When variables are changed outside the Console Variables Editor, this option will add the variables to the current preset.</summary>
	public bool bAddAllChangedConsoleVariablesToCurrentPreset;
	///<summary>If bAddAllChangedConsoleVariablesToCurrentPreset is true, this list will filter out any matching variables</summary>
	public TSet<string> ChangedConsoleVariableSkipList;
}
