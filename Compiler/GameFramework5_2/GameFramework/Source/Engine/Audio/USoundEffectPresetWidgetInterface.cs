#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/SoundEffectPresetWidgetInterface.h")]
public partial class USoundEffectPresetWidgetInterface : UAudioPanelWidgetInterface {
	///<summary>Returns the class of Preset the widget supports</summary>
	public  UClass GetClass() { return default; }
	///<summary>Called when the preset widget is constructed</summary>
	public  void OnConstructed(USoundEffectPreset Preset) {}
	///<summary>Called when the preset object is changed</summary>
	public  void OnPropertyChanged(USoundEffectPreset Preset,string PropertyName) {}
}
