#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Filter the particles on which the field will be applied</summary>
public partial class UFieldSystemMetaDataFilter : UFieldSystemMetaData {
// FieldSystemMetaDataFilter
	public  UFieldSystemMetaDataFilter SetMetaDataFilterType(EFieldFilterType FilterType,EFieldObjectType ObjectType,EFieldPositionType PositionType) { return default; }
	public EFieldFilterType FilterType;
	public EFieldObjectType ObjectType;
	public EFieldPositionType PositionType;
}
