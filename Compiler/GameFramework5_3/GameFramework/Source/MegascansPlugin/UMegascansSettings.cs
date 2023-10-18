namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSSettings.h")]
public partial class UMegascansSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Populate Foliage Editor with Foliage Types for 3D Plants.</summary>
	public bool bCreateFoliage;
	///<summary>Apply imported Surface on selected Actors in Editor.</summary>
	public bool bApplyToSelection;
}
