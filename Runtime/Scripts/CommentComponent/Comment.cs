namespace CommentComponent {
	using UnityEngine;

	/// <summary>
	/// Editor only component to add comments to game objects.
	/// </summary>
	[DisallowMultipleComponent]
	public class Comment : MonoBehaviour {
		
#if UNITY_EDITOR
		[SerializeField, TextArea(3, 10)]
		private string comment;
#endif

		private void Awake() => Destroy(this);
	}
}
