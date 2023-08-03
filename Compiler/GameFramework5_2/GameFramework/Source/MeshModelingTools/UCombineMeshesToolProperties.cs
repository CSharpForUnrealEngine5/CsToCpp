#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common properties</summary>
[CppInclude("CombineMeshesTool.h")]
public partial class UCombineMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bIsDuplicateMode</summary>
	public bool bIsDuplicateMode;
	///<summary>Defines the object the tool output is written to.</summary>
	public EBaseCreateFromSelectedTargetType OutputWriteTo;
	///<summary>Base name of the newly generated object to which the output is written to.</summary>
	public string OutputNewName;
	///<summary>Name of the existing object to which the output is written to.</summary>
	public string OutputExistingName;
}
