namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class contains the default values of render grid jobs.</summary>
[CppInclude("RenderGrid/RenderGrid.h")]
public partial class URenderGridSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Level</summary>
	public TSoftObjectPtr<UWorld> Level;
	///<summary>EditInstanceOnly, Category=&quot;Render Grid&quot;, Meta=(DisplayName=&quot;Properties Type&quot;)</summary>
	public ERenderGridPropsSourceType PropsSourceType;
	///<summary>, EditCondition=&quot;PropsSourceType == ERenderGridPropsSourceType::RemoteControl&quot;, EditConditionHides</summary>
	public URemoteControlPreset PropsSourceOrigin_RemoteControl;
	///<summary>GetPropsSource calls are somewhat expensive, we speed that up by caching the result (the PropsSource) that has been last outputted by that function.</summary>
	public URenderGridPropsSourceBase CachedPropsSource;
	///<summary>GetPropsSource calls are somewhat expensive, we speed that up by caching the PropsSourceType last used in that function.</summary>
	public ERenderGridPropsSourceType CachedPropsSourceType;
	///<summary>GetPropsSource calls are somewhat expensive, we speed that up by caching the PropsSourceOrigin last used in that function.</summary>
	public TWeakObjectPtr<UObject> CachedPropsSourceOriginWeakPtr;
}
