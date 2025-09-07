/*
[�X�N���v�g��] BootLoader.cs
����: �A�v���N�����iBoot�V�[���j�ɁA�w�肵���ŏ��̃V�[���i��: Title�j�ֈړ�����
�g����: Boot�V�[���̋��GameObject�ɃA�^�b�`�BInspector�� firstScene �ɑJ�ڐ�̃V�[����������
���S�҃���:
- Awake�̓V�[�����ǂݍ��܂�Ă���1�񂾂��Ă΂��B������60fps�Œ�Ȃǂ̏����ݒ������
- Start��Awake�̂��Ƃ�1��Ă΂��B�����ŃV�[���J�ڂ����s����
- �悭����~�X: Build Settings �ɑJ�ڐ�V�[�������Y���Ɠ����Ȃ�
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootLoader : MonoBehaviour
{
    [SerializeField, Tooltip("�N����ɍŏ��ɊJ���V�[����")]
    string firstScene = "Title";

    void Awake()
    {
        // 60fps�Œ�BvSync��؂��ăt���[�����[�g���A�v�����Ŏw��
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }

    void Start()
    {
        // �w�肵���V�[���ɐ؂�ւ�
        SceneManager.LoadScene(firstScene);
    }
}
