#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Filter the particles on which the field will be applied</summary>
public partial class UFieldSystemMetaDataFilter : UFieldSystemMetaData {
// FieldSystemMetaDataFilter
	public UObject SetMetaDataFilterType(EFieldFilterType FilterType,EFieldObjectType ObjectType,EFieldPositionType PositionType) { return default; }
	public byte FilterType;
	public byte ObjectType;
	public byte PositionType;
}
