namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ID of the template an entity is using</summary>
[CppInclude("MassEntityTemplate.h")]
public partial struct FMassEntityTemplateID {
	public FGuid ConfigGuid;
	public uint FlavorHash;
	public ulong TotalHash;
}
