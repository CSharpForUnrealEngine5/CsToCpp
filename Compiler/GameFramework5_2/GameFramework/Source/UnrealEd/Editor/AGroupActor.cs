namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/GroupActor.h")]
public partial class AGroupActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>bLocked</summary>
	public bool bLocked;
	///<summary>GroupActors</summary>
	public TArray<AActor> GroupActors;
	///<summary>SubGroups</summary>
	public TArray<AGroupActor> SubGroups;
}
