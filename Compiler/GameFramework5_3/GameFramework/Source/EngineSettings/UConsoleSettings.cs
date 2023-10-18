namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the UConsole class.</summary>
[CppInclude("ConsoleSettings.h")]
public partial class UConsoleSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The maximum number of lines the console keeps in its output history.</summary>
	public int MaxScrollbackSize;
	///<summary>Manual list of auto-complete commands and info specified in BaseInput.ini</summary>
	public TArray<FAutoCompleteCommand> ManualAutoCompleteList;
	///<summary>List of relative paths (e.g. Content/Maps) to search for map names for auto-complete usage. Specified in BaseInput.ini.</summary>
	public TArray<string> AutoCompleteMapPaths;
	///<summary>Amount of transparency of the console background.</summary>
	public float BackgroundOpacityPercentage;
	///<summary>Whether we legacy bottom-to-top ordering or regular top-to-bottom ordering</summary>
	public bool bOrderTopToBottom;
	///<summary>Display the first line of any available help text in the auto-complete window, if a description isn&#39;t available</summary>
	public bool bDisplayHelpInAutoComplete;
	///<summary>The color used for text input.</summary>
	public FColor InputColor;
	///<summary>The color used for the previously typed commands history.</summary>
	public FColor HistoryColor;
	///<summary>The autocomplete color used for executable commands.</summary>
	public FColor AutoCompleteCommandColor;
	///<summary>The autocomplete color used for mutable CVars.</summary>
	public FColor AutoCompleteCVarColor;
	///<summary>The autocomplete color used for command descriptions and read-only CVars.</summary>
	public FColor AutoCompleteFadedColor;
}
