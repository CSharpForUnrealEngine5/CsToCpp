#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct type that is generated from an FMovieSceneChannel type to create a single edit interface for a key/value pair</summary>
[CppInclude("SequencerKeyStructGenerator.h")]
public partial class UMovieSceneKeyStructType : UScriptStruct {
	public static UClass StaticClass() {return default;}
	///<summary>The (external) source TArray&lt;FFrameNumber&gt; property that stores the key times in the channel</summary>
	public object SourceTimesProperty;
	///<summary>The (external) source TArray&lt;T&gt; property that stores the key values in the channel</summary>
	public object SourceValuesProperty;
	///<summary>The time property for this reflected struct, of type FFrameNumber</summary>
	public object DestTimeProperty;
	///<summary>The value property for this reflected struct, of the same type as SourceValuesProperty-&gt;Inner</summary>
	public object DestValueProperty;
}
