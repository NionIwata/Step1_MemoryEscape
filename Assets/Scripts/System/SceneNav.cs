/*
[�X�N���v�g��] SceneNav.cs
����: UI�{�^������V�[���J�ڂ��ȒP�ɌĂяo��
�g����: Title/Stage1/Result �Ȃǂ�Canvas�i�܂��͋�I�u�W�F�N�g�j�ɃA�^�b�`���AButton��OnClick�Ŋ֐���I��
���S�҃���:
- public���\�b�h��Button��OnClick�ɕ\�������
- �V�[������Build Settings�ɕK���ǉ����Ă���
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNav : MonoBehaviour
{
    // �^�C�g���֖߂�
    public void LoadTitle() => SceneManager.LoadScene("Title");
    // �X�e�[�W1��
    public void LoadStage1() => SceneManager.LoadScene("Stage1");
    // ���U���g��
    public void LoadResult() => SceneManager.LoadScene("Result");
}
