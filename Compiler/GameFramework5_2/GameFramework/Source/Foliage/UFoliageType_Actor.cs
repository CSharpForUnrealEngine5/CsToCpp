#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageType_Actor.h")]
public partial class UFoliageType_Actor : UFoliageType {
	///<summary>ActorClass</summary>
	public UClass ActorClass;
	///<summary>bShouldAttachToBaseComponent</summary>
	public bool bShouldAttachToBaseComponent;
	///<summary>If enabled, will place an instanced static mesh representation of this actor without placing an actual actor</summary>
	public bool bStaticMeshOnly;
	///<summary>StaticMeshOnlyComponentClass</summary>
	public UClass StaticMeshOnlyComponentClass;
}
