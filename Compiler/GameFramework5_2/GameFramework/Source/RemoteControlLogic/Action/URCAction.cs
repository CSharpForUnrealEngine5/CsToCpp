#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for remote control action</summary>
[CppInclude("Action/RCAction.h")]
public partial class URCAction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Exposed Property or Function field Id</summary>
	public FGuid ExposedFieldId;
	///<summary>Action Id</summary>
	public FGuid Id;
	///<summary>Reference to preset</summary>
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
}
