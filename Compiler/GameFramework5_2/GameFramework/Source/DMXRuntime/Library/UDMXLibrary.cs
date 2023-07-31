#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXLibrary.h")]
public partial class UDMXLibrary : UDMXObjectBase {
	///<summary>Input ports of the Library</summary>
	public FDMXLibraryPortReferences PortReferences;
	///<summary>All Fixture Types and Fixture Patches in the Library</summary>
	public TArray<UDMXEntity> Entities;
	///<summary>The General Scene Description of this Library</summary>
	public UDMXMVRGeneralSceneDescription GeneralSceneDescription;
}
