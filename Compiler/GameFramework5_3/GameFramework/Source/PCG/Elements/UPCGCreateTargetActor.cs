namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGCreateTargetActor.h")]
public partial class UPCGCreateTargetActor : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>TemplateActorClass</summary>
	public UClass TemplateActorClass;
	///<summary>TemplateActor</summary>
	public AActor TemplateActor;
	///<summary>TODO: make this InlineEditConditionToggle, not done because property changed event does not propagate correctly so we can&#39;t track accurately the need to create the target actor</summary>
	public bool bAllowTemplateActorEditing;
	///<summary>AttachOptions</summary>
	public EPCGAttachOptions AttachOptions;
	///<summary>RootActor</summary>
	public TSoftObjectPtr<AActor> RootActor;
	///<summary>ActorLabel</summary>
	public string ActorLabel;
	///<summary>ActorPivot</summary>
	public FTransform ActorPivot;
}
