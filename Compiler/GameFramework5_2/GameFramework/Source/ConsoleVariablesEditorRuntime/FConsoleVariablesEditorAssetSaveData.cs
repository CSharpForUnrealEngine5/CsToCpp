namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data that will be serialized with this asset</summary>
[CppInclude("ConsoleVariablesAsset.h")]
public partial struct FConsoleVariablesEditorAssetSaveData {
	public string CommandName;
	public string CommandValueAsString;
	public ECheckBoxState CheckedState;
}
