namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Section data for each track. Reference of data will be stored in the child class for the way they want</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial struct FCompositeSection {
	public string SectionName;
	public float StartTime_DEPRECATED;
	public string NextSectionName;
	public TArray<UAnimMetaData> MetaData;
}
