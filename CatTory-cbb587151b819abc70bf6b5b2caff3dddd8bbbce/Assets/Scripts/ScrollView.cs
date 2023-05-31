using UnityEngine;
using UnityEngine.UI;   // UI�� ���õ� ��ũ��Ʈ �۾��� ���ؼ� �߰��� �־�� �Ѵ�.
using System.Collections;

public class ScrollView : MonoBehaviour
{
    // ��ũ�� ��� ���õ� ������ �ϱ� ���� ������ �ִ� ����
    ScrollRect scrollRect;

    // Use this for initialization
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();    // ���� ������Ʈ�� ������ �ִ� ScrollRect�� �����´�.

    }

    void SetContentSize()
    {
        float width = 100.0f;
        float height = 100.0f;
        // scrollRect.content�� ���ؼ� Hierachy �信�� �ô� Viewport ���� Content ���� ������Ʈ�� ������ �� �ִ�.
        // �׸��� sizeDelta ���� ���ؼ� Content�� ���̿� ���̸� ������ �� �ִ�.
        scrollRect.content.sizeDelta = new Vector2(width, height);
    }
}