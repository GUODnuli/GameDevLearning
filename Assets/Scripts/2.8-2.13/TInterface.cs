using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ӿ�
// �ӿ���һ�ֹ淶����һ��Լ��
// �ӿڲ��ɱ�ʵ����
// �ӿ��еķ��������з�����
// �ӿ��еķ��������з������η���Ĭ��Ϊpublic
// �ӿڿ��Ա��̳�

public class TInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

interface BaseInterface
{
    void ShowWindow();
    void HideWindow();
}

interface BaseInterface2 //: BaseInterface
{
    void PlaySound();
    void CloseSound();
}

interface BaseInterface3 : BaseInterface, BaseInterface2 // �ӿڿ��Ա��̳У����Ե�һ�̳У�Ҳ���Զ��ؼ̳�
{
    new void ShowWindow();
    new void HideWindow();
    new void PlaySound();
    new void CloseSound();
}