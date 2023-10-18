namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the MVVM Editor</summary>
[CppInclude("MVVMDeveloperProjectSettings.h")]
public partial class UMVVMDeveloperProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Permission list for filtering which properties are visible in UI.</summary>
	public TMap<FSoftClassPath,FMVVMDeveloperProjectWidgetSettings> FieldSelectorPermissions;
	///<summary>Permission list for filtering which execution mode is allowed.</summary>
	public TSet<EMVVMExecutionMode> AllowedExecutionMode;
	///<summary>Permission list for filtering which context creation type is allowed.</summary>
	public TSet<EMVVMBlueprintViewModelContextCreationType> AllowedContextCreationType;
	///<summary>Binding can be made from the DetailView Bind option.</summary>
	public bool bAllowBindingFromDetailView;
	///<summary>When generating a source in the viewmodel editor, allow the compiler to generate a setter function.</summary>
	public bool bAllowGeneratedViewModelSetter;
	///<summary>When generating a binding with a long source path, allow the compiler to generate a new viewmodel source.</summary>
	public bool bAllowLongSourcePath;
	///<summary>For the binding list widget, allow the user to edit the binding in the detail view.</summary>
	public bool bShowDetailViewOptionInBindingPanel;
	///<summary>For the binding list widget and the viewmodel panel, allow the user to edit the view settings in the detail view.</summary>
	public bool bShowViewSettings;
	///<summary>When a conversion function requires a wrapper graph, add and save the generated graph to the blueprint.</summary>
	public bool bAllowConversionFunctionGeneratedGraphInEditor;
	///<summary>Permission list for filtering which execution mode is allowed.</summary>
	public EMVVMDeveloperConversionFunctionFilterType ConversionFunctionFilter;
	///<summary>Individual class that are allowed to be uses as conversion functions.</summary>
	public TSet<FSoftClassPath> AllowedClassForConversionFunctions;
	///<summary>Settings for filtering the list of available properties and functions on binding creation.</summary>
	public FMVVMViewBindingFilterSettings FilterSettings;
}
