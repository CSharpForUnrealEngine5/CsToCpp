namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifier.h")]
public partial class UVCamModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetOwningVCamComponent</summary>
	public UVCamComponent GetOwningVCamComponent() { return default; }
	///<summary>GetCurrentLiveLinkDataFromOwningComponent</summary>
	public void GetCurrentLiveLinkDataFromOwningComponent(FLiveLinkCameraBlueprintData LiveLinkData) {}
	///<summary>SetEnabled</summary>
	public void SetEnabled(bool bNewEnabled) {}
	///<summary>IsEnabled</summary>
	public bool IsEnabled() { return default; }
	///<summary>Sets the name of the modifier in the associated modifier stack</summary>
	public bool SetStackEntryName(string NewName) { return default; }
	///<summary>Gets the name of the modifier in the associated modifier stack</summary>
	public string GetStackEntryName() { return default; }
	///<summary>If an Input Mapping Context is specified then that Context will be automatically added to the input system when this Modifier is Initialized</summary>
	public UInputMappingContext InputMappingContext;
	///<summary>If an Input Mapping Context is provided then this value defines the priority level that the context is added to the input system with</summary>
	public int InputContextPriority;
	///<summary>ConnectionPoints</summary>
	public TMap<string,FVCamModifierConnectionPoint> ConnectionPoints;
	///<summary>bIsInitialized</summary>
	public bool bIsInitialized;
}
