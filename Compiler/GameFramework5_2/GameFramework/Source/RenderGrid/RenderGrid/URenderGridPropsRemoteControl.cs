namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The remote control properties implementation of the render grid properties abstraction.</summary>
[CppInclude("RenderGrid/RenderGridPropsSource.h")]
public partial class URenderGridPropsRemoteControl : URenderGridPropsBase {
	public static UClass StaticClass() {return default;}
	///<summary>The source of properties, which is a remote control preset.</summary>
	public URemoteControlPreset RemoteControlPreset;
}
