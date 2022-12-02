namespace JasonSkillman.CommentComponent.Editor {
	using UnityEditor.Callbacks;
	using UnityEngine;

	/// <summary>
	/// Removes all <see cref="Comment"/> components from all game objects.
	/// </summary>
	public static class CommentPostprocessor {

		[PostProcessScene]
		public static void OnPostprocessScene() {
			Comment[] comments = Object.FindObjectsOfType<Comment>(true);

			for(int i = 0; i < comments.Length; i++)
				Object.DestroyImmediate(comments[i]);
		}
	}
}
