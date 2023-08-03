#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all entity types</summary>
[CppInclude("Library/DMXEntity.h")]
public partial class UDMXEntity : UDMXObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name</summary>
	public string Name;
	///<summary>ParentLibrary</summary>
	public TWeakObjectPtr<UDMXLibrary> ParentLibrary;
	///<summary>Uniquely identifies the parameter, used for fixing up Blueprints that reference this Entity when renaming.</summary>
	public FGuid Id;
}
