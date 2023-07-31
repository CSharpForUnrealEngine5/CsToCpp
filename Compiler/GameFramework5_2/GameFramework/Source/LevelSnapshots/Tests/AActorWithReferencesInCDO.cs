#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/ActorWithReferencesInCDO.h")]
public partial class AActorWithReferencesInCDO : AActor {
	///<summary>***************** Properties  *******************</summary>
	public TArray<FExternalReferenceDummy> Array;
	///<summary>Set</summary>
	public TSet<FExternalReferenceDummy> Set;
	///<summary>IntKeyMap</summary>
	public TMap<int,FExternalReferenceDummy> IntKeyMap;
	///<summary>IntValueMap</summary>
	public TMap<FExternalReferenceDummy,int> IntValueMap;
	///<summary>Struct</summary>
	public FExternalReferenceDummy Struct;
	///<summary>***************** External references  *******************</summary>
	public UStaticMesh CubeMesh;
	///<summary>CylinderMesh</summary>
	public UStaticMesh CylinderMesh;
}
