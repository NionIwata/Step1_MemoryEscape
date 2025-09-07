/*
[�X�N���v�g��] SaveSystem.cs
����: PlayerPrefs���g�����ȈՃZ�[�u�B��Ƃ��āu���oA�擾�̗L���v��ۑ�/�ǂݍ��݂���
�g����: �ǂ�����ł� SaveSystem.VisualA = true; �̂悤�Ɏg����istatic�N���X�j
���S�҃���:
- PlayerPrefs �̓L�[�Ɛ���/�������[���ɕۑ�����d�g��
- ���JSON�ۑ��ɒu��������O��́g���h�Ƃ��Ďg��
*/
using UnityEngine;

public static class SaveSystem
{
    const string KeyVisualA = "visual_A";  // �L�[���i���Ȃ��悤�ɉp���Łj

    // ���oA���擾�ς݂�
    public static bool VisualA
    {
        get => PlayerPrefs.GetInt(KeyVisualA, 0) == 1;
        set { PlayerPrefs.SetInt(KeyVisualA, value ? 1 : 0); PlayerPrefs.Save(); }
    }

    // ���ׂď������i�J�����̂�蒼���p�j
    public static void ResetAll()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
