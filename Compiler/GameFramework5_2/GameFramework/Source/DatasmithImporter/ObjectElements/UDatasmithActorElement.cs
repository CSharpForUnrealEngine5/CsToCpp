namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithActorElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithActorElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Get absolute translation of this entity</summary>
	public FVector GetTranslation() { return default; }
	///<summary>Set absolute translation of this entity</summary>
	public void SetTranslation(FVector Value) {}
	///<summary>Get absolute scale of this entity</summary>
	public FVector GetScale() { return default; }
	///<summary>Set absolute scale of this entity</summary>
	public void SetScale(FVector Value) {}
	///<summary>Get rotation (in quaternion format) of this entity</summary>
	public FQuat GetRotation() { return default; }
	///<summary>Set rotation (in quaternion format) of this entity</summary>
	public void SetRotation(FQuat Value) {}
	///<summary>Get the the name of the layer that contains this entity</summary>
	public string GetLayer() { return default; }
	///<summary>Set the the the layer that contains this entity, layer will be auto-created from its name</summary>
	public void SetLayer(string InLayer) {}
	///<summary>Get the tags of an Actor element</summary>
	public TArray<string> GetTags() { return default; }
	///<summary>Set the tags of an Actor element</summary>
	public void SetTags(TArray<string> InTags) {}
	///<summary>Adds a child to the Actor Element</summary>
	public void AddChild(UDatasmithActorElement InChild) {}
	///<summary>Get the number of children on this actor</summary>
	public int GetChildrenCount() { return default; }
	///<summary>Get the children of the mesh actor. Use AddChild -or- RemoveChild to modify the actor&#39;s children</summary>
	public TArray<UDatasmithActorElement> GetChildren() { return default; }
	///<summary>Remove a new child from the Actor Element</summary>
	public void RemoveChild(UDatasmithActorElement InChild) {}
	///<summary>Get the actor&#39;s visibility</summary>
	public bool GetVisibility() { return default; }
	///<summary>Set the actor&#39;s visibility</summary>
	public void SetVisibility(bool bInVisibility) {}
}
