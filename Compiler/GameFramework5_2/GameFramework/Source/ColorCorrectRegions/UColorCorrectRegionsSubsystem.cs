#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>World Subsystem responsible for managing AColorCorrectRegion classes in level.</summary>
[CppInclude("ColorCorrectRegionsSubsystem.h")]
public partial class UColorCorrectRegionsSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Resets all stencils and re-assigns for each CCR in the scene.</summary>
	public  void RefreshStenciIdAssignmentForAllCCR() {}
}
