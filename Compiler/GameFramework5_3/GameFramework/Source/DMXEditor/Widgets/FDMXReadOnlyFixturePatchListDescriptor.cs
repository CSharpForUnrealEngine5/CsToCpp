namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to describe a fixture patch list, so it can be stored in settings</summary>
[CppInclude("Widgets/SDMXReadOnlyFixturePatchList.h")]
public partial struct FDMXReadOnlyFixturePatchListDescriptor {
	public FName SortedByColumnID;
	public TMap<FName,bool> ColumnIDToShowStateMap;
}
