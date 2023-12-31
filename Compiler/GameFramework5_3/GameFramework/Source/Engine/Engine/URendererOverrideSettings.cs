namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
public partial class URendererOverrideSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>&quot;Enabling will locally override all ShaderPermutationReduction settings from the Renderer section to be enabled.  Saved to local user config only..&quot;</summary>
	public bool bSupportAllShaderPermutations;
}
