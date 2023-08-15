namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Views/List/SObjectMixerEditorList.h")]
public partial struct FObjectMixerSceneOutlinerColumnInfo {
	public FName PropertyName;
	public FName ColumnID;
	public FText PropertyDisplayText;
	public EListViewColumnType PropertyType;
	public FName PropertyCategoryName;
	public bool bIsDesiredForDisplay;
	public bool bCanBeHidden;
	public bool bCanBeSorted;
	public bool bUseFixedWidth;
	public float FixedWidth;
	public float FillWidth;
}
