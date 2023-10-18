namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Outliner configuration. *</summary>
[CppInclude("SGeometryCollectionOutliner.h")]
public partial class UOutlinerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>whether to use level coloring</summary>
	public bool ColorByLevel;
	///<summary>the column to be display in the outliner</summary>
	public EOutlinerColumnMode ColumnMode;
}
