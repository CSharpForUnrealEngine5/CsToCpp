namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptPluginSettings.h")]
public partial class UPythonScriptPluginUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Should Developer Mode be enabled on the Python interpreter?</summary>
	public bool bDeveloperMode;
	///<summary>Should the generated Python stub and API documentation have type hints. This enables standard Python type hinting (PEP 484) for the classes,</summary>
	public ETypeHintingMode TypeHintingMode;
	///<summary>Should Python scripts be available in the Content Browser?</summary>
	public bool bEnableContentBrowserIntegration;
}
