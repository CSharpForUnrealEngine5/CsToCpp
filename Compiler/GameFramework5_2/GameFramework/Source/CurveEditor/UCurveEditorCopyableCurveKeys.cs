#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveEditorCopyBuffer.h")]
public partial class UCurveEditorCopyableCurveKeys : UObject {
	///<summary>KeyPositions</summary>
	public TArray<FKeyPosition> KeyPositions;
	///<summary>KeyAttributes</summary>
	public TArray<FKeyAttributes> KeyAttributes;
	///<summary>This curve&#39;s short display name. Used in situations where other mechanisms provide enough context about what the curve is (such as &quot;X&quot;)</summary>
	public string ShortDisplayName;
	///<summary>This curve&#39;s long display name. Used in situations where the UI doesn&#39;t provide enough context about what the curve is otherwise (such as &quot;Floor.Transform.X&quot;)</summary>
	public string LongDisplayName;
	///<summary>This curve&#39;s short intention (such as Transform.X or Scale.X). Used internally to match up curves when saving/restoring curves between different objects.</summary>
	public string IntentionName;
	///<summary>This curve&#39;s long intention (such as foot_fk_l.Transform.X or foot_fk_r.Scale.X). Used internally to match up curves when saving/restoring curves between different objects.</summary>
	public string LongIntentionName;
}
