namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the implementation responsible for executing the rendering of</summary>
[CppInclude("MoviePipelineInProcessExecutorSettings.h")]
public partial class UMoviePipelineInProcessExecutorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled the editor will close itself when a new process is started. This can be used to gain some performance.</summary>
	public bool bCloseEditor;
	///<summary>A list of additional command line arguments to be appended to the new process startup. In the form of &quot;-foo -bar=baz&quot;. Can be useful if your game requires certain arguments to start such as disabling log-in screens.</summary>
	public string AdditionalCommandLineArguments;
	///<summary>A list of command line arguments which are inherited from the currently running Editor instance that will be automatically appended to the new process.</summary>
	public string InheritedCommandLineArguments;
	///<summary>How long should we wait after being initialized to start doing any work? This can be used</summary>
	public int InitialDelayFrameCount;
}
