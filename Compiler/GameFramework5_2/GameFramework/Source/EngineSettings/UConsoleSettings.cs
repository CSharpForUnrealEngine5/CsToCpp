#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConsoleSettings.h")]
///<summary>Implements the settings for the UConsole class.</summary>
public partial class UConsoleSettings : UObject {
// ConsoleSettings
	public int MaxScrollbackSize;
	public TArray<FAutoCompleteCommand> ManualAutoCompleteList;
	public TArray<string> AutoCompleteMapPaths;
	public float BackgroundOpacityPercentage;
	public bool bOrderTopToBottom;
	public bool bDisplayHelpInAutoComplete;
	public FColor InputColor;
	public FColor HistoryColor;
	public FColor AutoCompleteCommandColor;
	public FColor AutoCompleteCVarColor;
	public FColor AutoCompleteFadedColor;
}
