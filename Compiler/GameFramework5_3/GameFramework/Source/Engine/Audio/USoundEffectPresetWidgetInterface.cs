namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/SoundEffectPresetWidgetInterface.h")]
public partial class USoundEffectPresetWidgetInterface : UAudioPanelWidgetInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the class of Preset the widget supports</summary>
	public UClass GetClass() { return default; }
	///<summary>Called when the preset widget is constructed</summary>
	public void OnConstructed(USoundEffectPreset Preset) {}
	///<summary>Called when the preset object is changed</summary>
	public void OnPropertyChanged(USoundEffectPreset Preset,FName PropertyName) {}
}
