#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGrid.h")]
///<summary>This class contains the default values of render grid jobs.</summary>
public partial class URenderGridSettings : UObject {
// RenderGridSettings
	public ERenderGridPropsSourceType PropsSourceType;
	public URemoteControlPreset PropsSourceOrigin_RemoteControl;
	public URenderGridPropsSourceBase CachedPropsSource;
	public ERenderGridPropsSourceType CachedPropsSourceType;
	public TWeakObjectPtr<UObject> CachedPropsSourceOriginWeakPtr;
}
