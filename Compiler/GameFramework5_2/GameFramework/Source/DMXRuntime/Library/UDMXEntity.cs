#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntity.h")]
///<summary>Base class for all entity types</summary>
public partial class UDMXEntity : UDMXObjectBase {
// DMXEntity
	public string Name;
	public TWeakObjectPtr<UDMXLibrary> ParentLibrary;
	public FGuid Id;
}
