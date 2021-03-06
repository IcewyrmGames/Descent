﻿using UnityEngine;

namespace StoryReading {
	public class StoryButtons : StoryBehaviour {
		[SerializeField] StoryButton[] _choiceButtons;

		public override void OnStoryLoaded(StoryReader reader) {
			ClearButtons();
		}

		public override void OnStoryBeforeContinue() {
			ClearButtons();
		}

		public override void OnStoryOption(string optionText, int optionIndex) {
			if (optionIndex > -1 && optionIndex < _choiceButtons.Length) {
				_choiceButtons[optionIndex].Setup(
					optionText, null);
			} else {
				Debug.LogWarning("Invalid option index "+optionIndex.ToString());
			}
		}

		void ClearButtons() {
			for (int i = 0; i < _choiceButtons.Length; i++)
				_choiceButtons[i].Clear();
		}
	}
}
