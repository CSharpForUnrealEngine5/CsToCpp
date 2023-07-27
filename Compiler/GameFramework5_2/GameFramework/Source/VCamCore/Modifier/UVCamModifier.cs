#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifier.h")]
public partial class UVCamModifier : UObject {
// VCamModifier
	public  UVCamComponent GetOwningVCamComponent() { return default; }
	public  void GetCurrentLiveLinkDataFromOwningComponent(FLiveLinkCameraBlueprintData LiveLinkData) {}
	public  void SetEnabled(bool bNewEnabled) {}
	public  bool IsEnabled() { return default; }
	public  bool SetStackEntryName(string NewName) { return default; }
	public  string GetStackEntryName() { return default; }
	public UInputMappingContext InputMappingContext;
	public int InputContextPriority;
	public TMap<string,FVCamModifierConnectionPoint> ConnectionPoints;
	public bool bIsInitialized;
}
