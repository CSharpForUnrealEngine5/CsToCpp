#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprintFactory.h")]
public partial class UControlRigBlueprintFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The parent class of the created blueprint</summary>
	public UClass ParentClass;
	///<summary>Create a new control rig asset within the contents space of the project.</summary>
	public static UControlRigBlueprint CreateNewControlRigAsset(string InDesiredPackagePath) { return default; }
	///<summary>Create a new control rig asset within the contents space of the project</summary>
	public static UControlRigBlueprint CreateControlRigFromSkeletalMeshOrSkeleton(UObject InSelectedObject) { return default; }
}
