namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example Command Line: ProjectName MapName -run=WorldPartitionBuilderCommandlet -SCCProvider=Perforce -Builder=WorldPartitionResaveActorsBuilder [-ActorClassName=StaticMeshActor] [-SwitchActorPackagingSchemeToReduced] [-ActorTags=(Tag1,Tag2,...)] [-ActorProperties=((Property1,Value1),(Property2,Value2),...)]</summary>
[CppInclude("WorldPartition/WorldPartitionResaveActorsBuilder.h")]
public partial class UWorldPartitionResaveActorsBuilder : UWorldPartitionBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>ActorClassName</summary>
	public string ActorClassName;
	///<summary>ActorClassesFromFile</summary>
	public string ActorClassesFromFile;
	///<summary>bReportOnly</summary>
	public bool bReportOnly;
	///<summary>bResaveDirtyActorDescsOnly</summary>
	public bool bResaveDirtyActorDescsOnly;
	///<summary>bDiffDirtyActorDescs</summary>
	public bool bDiffDirtyActorDescs;
	///<summary>bSwitchActorPackagingSchemeToReduced</summary>
	public bool bSwitchActorPackagingSchemeToReduced;
	///<summary>bEnableActorFolders</summary>
	public bool bEnableActorFolders;
	///<summary>ActorTags</summary>
	public TSet<FName> ActorTags;
	///<summary>ActorProperties</summary>
	public TMap<FName,FName> ActorProperties;
}
