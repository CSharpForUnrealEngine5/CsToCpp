#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/DataflowSettings.h")]
public partial class UDataflowSettings : UDeveloperSettings {
	///<summary>TArray&lt;&gt; pin type color. The other pin colors are defined in the general editor settings.</summary>
	public FLinearColor ArrayPinTypeColor;
	///<summary>FManagedArrayCollection pin type color. The other pin colors are defined in the general editor settings.</summary>
	public FLinearColor ManagedArrayCollectionPinTypeColor;
	///<summary>FBox pin type color. The other pin colors are defined in the general editor settings.</summary>
	public FLinearColor BoxPinTypeColor;
	///<summary>FSphere pin type color. The other pin colors are defined in the general editor settings.</summary>
	public FLinearColor SpherePinTypeColor;
	///<summary>NodeColorsMap</summary>
	public TMap<string,FNodeColors> NodeColorsMap;
}
