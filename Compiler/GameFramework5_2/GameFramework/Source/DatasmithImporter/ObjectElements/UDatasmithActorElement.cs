#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>* UDatasmithActorElement</summary>
public partial class UDatasmithActorElement : UDatasmithObjectElement {
// DatasmithActorElement
	public  FVector GetTranslation() { return default; }
	public  void SetTranslation(FVector Value) {}
	public  FVector GetScale() { return default; }
	public  void SetScale(FVector Value) {}
	public  FQuat GetRotation() { return default; }
	public  void SetRotation(FQuat Value) {}
	public  string GetLayer() { return default; }
	public  void SetLayer(string InLayer) {}
	public  TArray<string> GetTags() { return default; }
	public  void SetTags(TArray<string> InTags) {}
	public  void AddChild(UDatasmithActorElement InChild) {}
	public  int GetChildrenCount() { return default; }
	public  TArray<UDatasmithActorElement> GetChildren() { return default; }
	public  void RemoveChild(UDatasmithActorElement InChild) {}
	public  bool GetVisibility() { return default; }
	public  void SetVisibility(bool bInVisibility) {}
}
