#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial class APropertyEditorTestActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>InstancedUObjectArray</summary>
	public TArray<UPropertyEditorTestInstancedObject> InstancedUObjectArray;
	///<summary>GetOptionsValue</summary>
	public string GetOptionsValue;
	///<summary>DefaultsOnly</summary>
	public float DefaultsOnly;
	///<summary>DefaultsOnlySubcategory</summary>
	public float DefaultsOnlySubcategory;
	///<summary>InstanceOnly</summary>
	public float InstanceOnly;
	///<summary>InstanceOnlySubcategory</summary>
	public float InstanceOnlySubcategory;
	///<summary>MultiLineMap</summary>
	public TMap<int,string> MultiLineMap;
	///<summary>GetOptionsFunc</summary>
	public  TArray<string> GetOptionsFunc() { return default; }
}
