namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The remote control properties implementation of the render grid properties source abstraction.</summary>
[CppInclude("RenderGrid/RenderGridPropsSource.h")]
public partial class URenderGridPropsSourceRemoteControl : URenderGridPropsSourceBase {
	public static UClass StaticClass() {return default;}
	///<summary>The source of properties, which is a remote control preset.</summary>
	public URemoteControlPreset RemoteControlPreset;
	///<summary>The preset group (of the remote control preset) that we should obtain the properties from.</summary>
	public FName ActivePresetGroup;
}
